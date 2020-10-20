using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    internal struct Statistics
    {
        internal int abortedCount;
        internal int retriedCount;
        internal int numRowsFound;
    }

    public class AbortedTransactionsTest
    {
        private const int NUM_WRITE_TASKS = 20;
        private const int NUM_READ_TASKS = 80;
        private const int TRANSACTIONS_PER_TASK = 100;
        private const int UPDATE_ROWS = 5;
        private const int ROW_RANGE = 1000;
        private readonly Random rnd = new Random();

        [Fact]
        public async Task TestStartup()
        {
            var builder = new SpannerConnectionStringBuilder
            {
                DataSource = $"projects/appdev-soda-spanner-staging/instances/test-instance/databases/testdb_941233300_0000",
            };
            string connectionString = builder.ConnectionString;
            using (var connection = new SpannerConnection(connectionString))
            {
                Debug.WriteLine($"Starting transaction at {DateTime.Now}");
                using (var tx = await connection.BeginTransactionAsync())
                {
                    Debug.WriteLine($"Transaction started at {DateTime.Now}");
                    long id = rnd.Next(1, ROW_RANGE);
                    SpannerCommand cmd = connection.CreateSelectCommand("SELECT * FROM Singers WHERE SingerId=@id", new SpannerParameterCollection
                    {
                        { "id", SpannerDbType.Int64, id },
                    });
                    await tx.CommitAsync();
                }
                Debug.WriteLine($"Finished transaction at {DateTime.Now}");
            }
        }

        [Fact]
        public async Task TestConnection()
        {
            var builder = new SpannerConnectionStringBuilder
            {
                DataSource = $"projects/appdev-soda-spanner-staging/instances/test-instance/databases/testdb_941233300_0000",
            };
            string connectionString = builder.ConnectionString;
            List<Task<Statistics>> tasks = new List<Task<Statistics>>();
            List<Task<Statistics>> writeTasks = new List<Task<Statistics>>();
            List<Task<Statistics>> readTasks = new List<Task<Statistics>>();
            for (int i = 0; i < NUM_WRITE_TASKS; i++)
            {
                var id = i;
                var task = Task.Run(() => RunReadWriteTransaction(id, connectionString));
                tasks.Add(task);
                writeTasks.Add(task);
            }
            for (int i = 0; i < NUM_READ_TASKS; i++)
            {
                var id = i;
                var task = Task.Run(() => RunReadOnlyTransactionAsReadWrite(id, connectionString));
                tasks.Add(task);
                readTasks.Add(task);
            }
            await Task.WhenAll(tasks);
            Debug.WriteLine($"");
            Debug.WriteLine($"Statistics for write tasks:");
            int taskId = 0;
            foreach (Task<Statistics> stat in writeTasks)
            {
                Debug.WriteLine($"Task {taskId} aborted: {stat.Result.abortedCount}");
                Debug.WriteLine($"Task {taskId} retried: {stat.Result.retriedCount}");
                taskId++;
            }
            Debug.WriteLine($"");
            Debug.WriteLine($"Statistics for read tasks:");
            taskId = 0;
            foreach (Task<Statistics> stat in readTasks)
            {
                Debug.WriteLine($"Task {taskId} aborted: {stat.Result.abortedCount}");
                Debug.WriteLine($"Task {taskId} retried: {stat.Result.retriedCount}");
                Debug.WriteLine($"Task {taskId} records found: {stat.Result.numRowsFound}");
                taskId++;
            }
        }

        private async Task<Statistics> RunReadWriteTransaction(int taskId, string connectionString)
        {
            Debug.WriteLine($"Task {taskId} starting at {DateTime.Now}");
            Statistics stats = new Statistics();
            using (var connection = new SpannerConnection(connectionString))
            {
                for (int i = 0; i < TRANSACTIONS_PER_TASK; i++)
                {
                    Debug.WriteLine($"Task {taskId}: Starting transaction {i} at {DateTime.Now}");
                    try
                    {
                        using (var tx = await connection.BeginTransactionAsync())
                        {
                            Assert.True(tx is RetriableSpannerTransaction);
                            // Update multiple rows in one transaction.
                            for (int row = 0; row < UPDATE_ROWS; row++)
                            {
                                // Do a simple read-and-then-insert/update.
                                long id = rnd.Next(1, ROW_RANGE);
                                SpannerCommand cmd = connection.CreateSelectCommand("SELECT * FROM Singers WHERE SingerId=@id", new SpannerParameterCollection
                                {
                                    { "id", SpannerDbType.Int64, id },
                                });
                                cmd.Transaction = tx;
                                var newName = $"FirstName {id} - random value {rnd.Next(Int32.MaxValue)}";
                                // Naive exists query to do an upsert.
                                bool exists = false;
                                using (SpannerDataReader reader = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader.ReadAsync())
                                    {
                                        Assert.Equal(id, reader.GetInt64(reader.GetOrdinal("SingerId")));
                                        exists = true;
                                    }
                                }
                                if (exists)
                                {
                                    cmd = connection.CreateDmlCommand(
                                        "UPDATE Singers SET FirstName=@name WHERE SingerId=@id",
                                        new SpannerParameterCollection
                                        {
                                            { "id", SpannerDbType.Int64, id },
                                            { "name", SpannerDbType.String, newName },
                                        }
                                    );
                                }
                                else
                                {
                                    cmd = connection.CreateDmlCommand(
                                        $"INSERT INTO Singers (SingerId, FirstName, LastName) VALUES (@id, @firstName, @lastName)",
                                        new SpannerParameterCollection
                                        {
                                            { "id", SpannerDbType.Int64, id },
                                            { "firstName", SpannerDbType.String, newName },
                                            { "lastName", SpannerDbType.String, $"LastName {id}" },
                                        }
                                    );
                                }
                                cmd.Transaction = tx;
                                long count = await cmd.ExecuteNonQueryAsync();
                                Assert.Equal(1, count);
                            }
                            await tx.CommitAsync();
                            if (tx is RetriableSpannerTransaction)
                            {
                                stats.retriedCount += ((RetriableSpannerTransaction)tx).RetryCount;
                            }
                        }
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                    {
                        Debug.WriteLine($"Task {taskId}: Transaction {i} aborted at {DateTime.Now}");
                        stats.abortedCount++;
                    }
                    Debug.WriteLine($"Task {taskId}: Finished transaction {i} at {DateTime.Now}");
                }
                Debug.WriteLine($"Task {taskId}: Aborted transactions: {stats.abortedCount}");
                Debug.WriteLine($"Task {taskId}: Retried transactions: {stats.retriedCount}");
            }
            return stats;
        }

        private async Task<Statistics> RunReadOnlyTransactionAsReadWrite(int taskId, string connectionString)
        {
            Debug.WriteLine($"Read-only task {taskId} starting at {DateTime.Now}");
            Statistics stats = new Statistics();
            using (var connection = new SpannerConnection(connectionString))
            {
                for (int i = 0; i < TRANSACTIONS_PER_TASK; i++)
                {
                    Debug.WriteLine($"Read-only task {taskId}: Starting transaction {i} at {DateTime.Now}");
                    try
                    {
                        using (var tx = await connection.BeginTransactionAsync())
                        {
                            Assert.True(tx is RetriableSpannerTransaction);
                            // Select a random set of singers.
                            var randomName = $"{rnd.Next(1, 999):D3}";
                            SpannerCommand cmd = connection.CreateSelectCommand($"SELECT * FROM Singers WHERE FirstName LIKE '%{randomName}%'");
                            cmd.Transaction = tx;
                            using (SpannerDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {
                                    var name = reader.GetString(reader.GetOrdinal("FirstName"));
                                    Assert.Contains(randomName, name);
                                    stats.numRowsFound++;
                                }
                            }
                            await tx.CommitAsync();
                            if (tx is RetriableSpannerTransaction)
                            {
                                stats.retriedCount += ((RetriableSpannerTransaction)tx).RetryCount;
                            }
                        }
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                    {
                        Debug.WriteLine($"Read-only task {taskId}: Transaction {i} aborted at {DateTime.Now}");
                        stats.abortedCount++;
                    }
                    Debug.WriteLine($"Read-only task {taskId}: Finished transaction {i} at {DateTime.Now}");
                }
                Debug.WriteLine($"Read-only task {taskId}: Aborted transactions: {stats.abortedCount}");
                Debug.WriteLine($"Read-only task {taskId}: Retried transactions: {stats.retriedCount}");
            }
            return stats;
        }

    }
}
