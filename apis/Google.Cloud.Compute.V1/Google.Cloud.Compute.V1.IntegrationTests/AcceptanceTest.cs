﻿// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Threading;
using Grpc.Core;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    /// <summary>
    /// Miscellaneous acceptance tests for the Compute API.
    /// </summary>
    [Collection(nameof(ComputeFixture))]
    public sealed class AcceptanceTest
    {
        private readonly ITestOutputHelper _output;
        private readonly ComputeFixture _fixture;

        public AcceptanceTest(ComputeFixture fixture, ITestOutputHelper output) =>
            (_fixture, _output) = (fixture, output);

        [Fact]
        public void CreateDeleteIPAddress()
        {
            string projectId = _fixture.ProjectId;
            string region = _fixture.Region;

            AddressesClient addressesClient = AddressesClient.Create();
            var addressName = _fixture.GenerateResourceId();

            FetchNonExistentAddress();
            CreateAddress();
            FetchNewAddress();
            DeleteAddress();

            void FetchNonExistentAddress()
            {
                _output.WriteLine($"Retrieving address with the name: {addressName}");
                var exc = Assert.Throws<RpcException>(() => addressesClient.Get(projectId, region, addressName));
                Assert.Equal(StatusCode.NotFound, exc.StatusCode);
            }

            void CreateAddress()
            {
                _output.WriteLine($"Creating address with the name: {addressName}");
                Address addressResource = new Address
                {
                    Name = addressName,
                    Region = region,
                    NetworkTier = Address.Types.NetworkTier.Premium
                };

                Operation insertOperation = addressesClient.Insert(projectId, region, addressResource);
                _output.WriteLine($"Operation to create address: {insertOperation.Name} status {insertOperation.Status}; start time {insertOperation.StartTime}");
                insertOperation = PollForCompletion(insertOperation, "create");
                _output.WriteLine($"Operation to create address completed: status {insertOperation.Status}; start time {insertOperation.StartTime}; end time {insertOperation.EndTime}");
            }

            void FetchNewAddress()
            {
                _output.WriteLine($"Retrieving address with the name: {addressName}");
                Address readAddr = addressesClient.Get(projectId, region, addressName);
                Assert.NotNull(readAddr);
                Assert.Equal(readAddr.Name, addressName);
            }

            void DeleteAddress()
            {
                _output.WriteLine($"Deleting address with the name: {addressName}");
                Operation deleteOp = addressesClient.Delete(projectId, region, addressName);
                _output.WriteLine($"Operation to delete address: {deleteOp.Name} status {deleteOp.Status}; start time {deleteOp.StartTime}");
                deleteOp = PollForCompletion(deleteOp, "delete");
                _output.WriteLine($"Operation to delete address completed: status {deleteOp.Status}; start time {deleteOp.StartTime}; end time {deleteOp.EndTime}");
            }
        }

        private Operation PollForCompletion(Operation operation, string alias)
        {
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();

            TimeSpan timeOut = TimeSpan.FromMinutes(3);
            TimeSpan pollInterval = TimeSpan.FromSeconds(15);

            DateTime deadline = DateTime.UtcNow + timeOut;
            while (operation.Status != Operation.Types.Status.Done)
            {
                GetRegionOperationRequest request = new GetRegionOperationRequest
                {
                    Operation = operation.Name,
                    Region = _fixture.Region,
                    Project = _fixture.ProjectId,
                };
                _output.WriteLine($"Checking for {alias} operation status ...");
                operation = regionOperationsClient.Get(request);

                if (operation.Status == Operation.Types.Status.Done) 
                {
                    break;
                }
                if (DateTime.UtcNow > deadline)
                {
                    throw new InvalidOperationException(
                        $"Timeout hit while polling for the status of the {alias} operation\n{operation}");
                }
                _output.WriteLine($"Status: {operation.Status}. Sleeping for the {pollInterval.TotalSeconds}s");
                Thread.Sleep(pollInterval);
            }

            return operation;
        }
    }
}
