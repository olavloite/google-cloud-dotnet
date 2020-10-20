using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SessionPoolStartupTests : IClassFixture<SpannerMockServerFixture>
    {
        SpannerMockServerFixture _fixture;

        public SessionPoolStartupTests(SpannerMockServerFixture service)
        {
            this._fixture = service;
            service.SpannerMock.AddOrUpdateStatementResult("SELECT 1", StatementResult.CreateSelect1ResultSet());
        }

        [Fact]
        public async void TestReadOnlyStartupTime()
        {
            _fixture.SpannerMock.AddOrUpdateExecutionTime(nameof(MockSpannerService.BatchCreateSessions), ExecutionTime.Time(10));
            _fixture.SpannerMock.AddOrUpdateExecutionTime(nameof(MockSpannerService.BeginTransaction), ExecutionTime.Time(10));
            Stopwatch watch = Stopwatch.StartNew();
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                using (var tx = await connection.BeginTransactionAsync())
                {
                    SpannerCommand cmd = connection.CreateSelectCommand("SELECT 1");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.Equal(1, reader.GetInt64(0));
                        }
                    }
                }
            }
            watch.Stop();
            Debug.WriteLine(watch.Elapsed);
            Debug.WriteLine($"Requests: {_fixture.SpannerMock.Requests().Count}");
            foreach (IMessage msg in _fixture.SpannerMock.Requests())
            {
                Debug.WriteLine(msg);
            }
        }
    }
}
