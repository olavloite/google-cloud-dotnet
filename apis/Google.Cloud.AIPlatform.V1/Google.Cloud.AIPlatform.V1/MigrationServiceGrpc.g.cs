// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/migration_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.AIPlatform.V1 {
  /// <summary>
  /// A service that migrates resources from automl.googleapis.com,
  /// datalabeling.googleapis.com and ml.googleapis.com to Vertex AI.
  /// </summary>
  public static partial class MigrationService
  {
    static readonly string __ServiceName = "google.cloud.aiplatform.v1.MigrationService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest> __Marshaller_google_cloud_aiplatform_v1_SearchMigratableResourcesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse> __Marshaller_google_cloud_aiplatform_v1_SearchMigratableResourcesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest> __Marshaller_google_cloud_aiplatform_v1_BatchMigrateResourcesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest, global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse> __Method_SearchMigratableResources = new grpc::Method<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest, global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchMigratableResources",
        __Marshaller_google_cloud_aiplatform_v1_SearchMigratableResourcesRequest,
        __Marshaller_google_cloud_aiplatform_v1_SearchMigratableResourcesResponse);

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest, global::Google.LongRunning.Operation> __Method_BatchMigrateResources = new grpc::Method<global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BatchMigrateResources",
        __Marshaller_google_cloud_aiplatform_v1_BatchMigrateResourcesRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AIPlatform.V1.MigrationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MigrationService</summary>
    [grpc::BindServiceMethod(typeof(MigrationService), "BindService")]
    public abstract partial class MigrationServiceBase
    {
      /// <summary>
      /// Searches all of the resources in automl.googleapis.com,
      /// datalabeling.googleapis.com and ml.googleapis.com that can be migrated to
      /// Vertex AI's given location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse> SearchMigratableResources(global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Batch migrates resources from ml.googleapis.com, automl.googleapis.com,
      /// and datalabeling.googleapis.com to Vertex AI.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> BatchMigrateResources(global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MigrationService</summary>
    public partial class MigrationServiceClient : grpc::ClientBase<MigrationServiceClient>
    {
      /// <summary>Creates a new client for MigrationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MigrationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MigrationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MigrationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MigrationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MigrationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Searches all of the resources in automl.googleapis.com,
      /// datalabeling.googleapis.com and ml.googleapis.com that can be migrated to
      /// Vertex AI's given location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse SearchMigratableResources(global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchMigratableResources(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches all of the resources in automl.googleapis.com,
      /// datalabeling.googleapis.com and ml.googleapis.com that can be migrated to
      /// Vertex AI's given location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse SearchMigratableResources(global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchMigratableResources, null, options, request);
      }
      /// <summary>
      /// Searches all of the resources in automl.googleapis.com,
      /// datalabeling.googleapis.com and ml.googleapis.com that can be migrated to
      /// Vertex AI's given location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse> SearchMigratableResourcesAsync(global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchMigratableResourcesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches all of the resources in automl.googleapis.com,
      /// datalabeling.googleapis.com and ml.googleapis.com that can be migrated to
      /// Vertex AI's given location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse> SearchMigratableResourcesAsync(global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchMigratableResources, null, options, request);
      }
      /// <summary>
      /// Batch migrates resources from ml.googleapis.com, automl.googleapis.com,
      /// and datalabeling.googleapis.com to Vertex AI.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation BatchMigrateResources(global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchMigrateResources(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batch migrates resources from ml.googleapis.com, automl.googleapis.com,
      /// and datalabeling.googleapis.com to Vertex AI.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation BatchMigrateResources(global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BatchMigrateResources, null, options, request);
      }
      /// <summary>
      /// Batch migrates resources from ml.googleapis.com, automl.googleapis.com,
      /// and datalabeling.googleapis.com to Vertex AI.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchMigrateResourcesAsync(global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchMigrateResourcesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batch migrates resources from ml.googleapis.com, automl.googleapis.com,
      /// and datalabeling.googleapis.com to Vertex AI.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchMigrateResourcesAsync(global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BatchMigrateResources, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MigrationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MigrationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MigrationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchMigratableResources, serviceImpl.SearchMigratableResources)
          .AddMethod(__Method_BatchMigrateResources, serviceImpl.BatchMigrateResources).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MigrationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SearchMigratableResources, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesRequest, global::Google.Cloud.AIPlatform.V1.SearchMigratableResourcesResponse>(serviceImpl.SearchMigratableResources));
      serviceBinder.AddMethod(__Method_BatchMigrateResources, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.BatchMigrateResourcesRequest, global::Google.LongRunning.Operation>(serviceImpl.BatchMigrateResources));
    }

  }
}
#endregion
