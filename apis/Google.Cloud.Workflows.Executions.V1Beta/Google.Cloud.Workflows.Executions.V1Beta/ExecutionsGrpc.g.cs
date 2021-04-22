// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/workflows/executions/v1beta/executions.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Cloud.Workflows.Executions.V1Beta {
  /// <summary>
  /// Executions is used to start and manage running instances of
  /// [Workflows][google.cloud.workflows.v1beta.Workflow] called executions.
  /// </summary>
  public static partial class Executions
  {
    static readonly string __ServiceName = "google.cloud.workflows.executions.v1beta.Executions";

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

    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest> __Marshaller_google_cloud_workflows_executions_v1beta_ListExecutionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse> __Marshaller_google_cloud_workflows_executions_v1beta_ListExecutionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest> __Marshaller_google_cloud_workflows_executions_v1beta_CreateExecutionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> __Marshaller_google_cloud_workflows_executions_v1beta_Execution = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.Execution.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest> __Marshaller_google_cloud_workflows_executions_v1beta_GetExecutionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest> __Marshaller_google_cloud_workflows_executions_v1beta_CancelExecutionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest.Parser));

    static readonly grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest, global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse> __Method_ListExecutions = new grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest, global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListExecutions",
        __Marshaller_google_cloud_workflows_executions_v1beta_ListExecutionsRequest,
        __Marshaller_google_cloud_workflows_executions_v1beta_ListExecutionsResponse);

    static readonly grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution> __Method_CreateExecution = new grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateExecution",
        __Marshaller_google_cloud_workflows_executions_v1beta_CreateExecutionRequest,
        __Marshaller_google_cloud_workflows_executions_v1beta_Execution);

    static readonly grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution> __Method_GetExecution = new grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetExecution",
        __Marshaller_google_cloud_workflows_executions_v1beta_GetExecutionRequest,
        __Marshaller_google_cloud_workflows_executions_v1beta_Execution);

    static readonly grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution> __Method_CancelExecution = new grpc::Method<global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelExecution",
        __Marshaller_google_cloud_workflows_executions_v1beta_CancelExecutionRequest,
        __Marshaller_google_cloud_workflows_executions_v1beta_Execution);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Workflows.Executions.V1Beta.ExecutionsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Executions</summary>
    [grpc::BindServiceMethod(typeof(Executions), "BindService")]
    public abstract partial class ExecutionsBase
    {
      /// <summary>
      /// Returns a list of executions which belong to the workflow with
      /// the given name. The method returns executions of all workflow
      /// revisions. Returned executions are ordered by their start time (newest
      /// first).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse> ListExecutions(global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new execution using the latest revision of the given workflow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CreateExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns an execution of the given name.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> GetExecution(global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Cancels an execution of the given name.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CancelExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Executions</summary>
    public partial class ExecutionsClient : grpc::ClientBase<ExecutionsClient>
    {
      /// <summary>Creates a new client for Executions</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ExecutionsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Executions that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ExecutionsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ExecutionsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ExecutionsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns a list of executions which belong to the workflow with
      /// the given name. The method returns executions of all workflow
      /// revisions. Returned executions are ordered by their start time (newest
      /// first).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse ListExecutions(global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListExecutions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of executions which belong to the workflow with
      /// the given name. The method returns executions of all workflow
      /// revisions. Returned executions are ordered by their start time (newest
      /// first).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse ListExecutions(global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListExecutions, null, options, request);
      }
      /// <summary>
      /// Returns a list of executions which belong to the workflow with
      /// the given name. The method returns executions of all workflow
      /// revisions. Returned executions are ordered by their start time (newest
      /// first).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse> ListExecutionsAsync(global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListExecutionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of executions which belong to the workflow with
      /// the given name. The method returns executions of all workflow
      /// revisions. Returned executions are ordered by their start time (newest
      /// first).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse> ListExecutionsAsync(global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListExecutions, null, options, request);
      }
      /// <summary>
      /// Creates a new execution using the latest revision of the given workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution CreateExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateExecution(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new execution using the latest revision of the given workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution CreateExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateExecution, null, options, request);
      }
      /// <summary>
      /// Creates a new execution using the latest revision of the given workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CreateExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateExecutionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new execution using the latest revision of the given workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CreateExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateExecution, null, options, request);
      }
      /// <summary>
      /// Returns an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution GetExecution(global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetExecution(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution GetExecution(global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetExecution, null, options, request);
      }
      /// <summary>
      /// Returns an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> GetExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetExecutionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> GetExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetExecution, null, options, request);
      }
      /// <summary>
      /// Cancels an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution CancelExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelExecution(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancels an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Workflows.Executions.V1Beta.Execution CancelExecution(global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelExecution, null, options, request);
      }
      /// <summary>
      /// Cancels an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CancelExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelExecutionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancels an execution of the given name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.Executions.V1Beta.Execution> CancelExecutionAsync(global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelExecution, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ExecutionsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExecutionsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ExecutionsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListExecutions, serviceImpl.ListExecutions)
          .AddMethod(__Method_CreateExecution, serviceImpl.CreateExecution)
          .AddMethod(__Method_GetExecution, serviceImpl.GetExecution)
          .AddMethod(__Method_CancelExecution, serviceImpl.CancelExecution).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ExecutionsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListExecutions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsRequest, global::Google.Cloud.Workflows.Executions.V1Beta.ListExecutionsResponse>(serviceImpl.ListExecutions));
      serviceBinder.AddMethod(__Method_CreateExecution, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.Executions.V1Beta.CreateExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(serviceImpl.CreateExecution));
      serviceBinder.AddMethod(__Method_GetExecution, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.Executions.V1Beta.GetExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(serviceImpl.GetExecution));
      serviceBinder.AddMethod(__Method_CancelExecution, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.Executions.V1Beta.CancelExecutionRequest, global::Google.Cloud.Workflows.Executions.V1Beta.Execution>(serviceImpl.CancelExecution));
    }

  }
}
#endregion
