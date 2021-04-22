// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/version.proto
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

namespace Google.Cloud.Dialogflow.Cx.V3 {
  /// <summary>
  /// Service for managing [Versions][google.cloud.dialogflow.cx.v3.Version].
  /// </summary>
  public static partial class Versions
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.Versions";

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

    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListVersionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListVersionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetVersionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.Version> __Marshaller_google_cloud_dialogflow_cx_v3_Version = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.Version.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest> __Marshaller_google_cloud_dialogflow_cx_v3_CreateVersionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest> __Marshaller_google_cloud_dialogflow_cx_v3_UpdateVersionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest> __Marshaller_google_cloud_dialogflow_cx_v3_DeleteVersionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest> __Marshaller_google_cloud_dialogflow_cx_v3_LoadVersionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest.Parser));

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse> __Method_ListVersions = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListVersions",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListVersionsRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListVersionsResponse);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version> __Method_GetVersion = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetVersion",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetVersionRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Version);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest, global::Google.LongRunning.Operation> __Method_CreateVersion = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateVersion",
        __Marshaller_google_cloud_dialogflow_cx_v3_CreateVersionRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version> __Method_UpdateVersion = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateVersion",
        __Marshaller_google_cloud_dialogflow_cx_v3_UpdateVersionRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Version);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteVersion = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteVersion",
        __Marshaller_google_cloud_dialogflow_cx_v3_DeleteVersionRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest, global::Google.LongRunning.Operation> __Method_LoadVersion = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LoadVersion",
        __Marshaller_google_cloud_dialogflow_cx_v3_LoadVersionRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.VersionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Versions</summary>
    [grpc::BindServiceMethod(typeof(Versions), "BindService")]
    public abstract partial class VersionsBase
    {
      /// <summary>
      /// Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse> ListVersions(global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Version> GetVersion(global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateVersion(global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Version> UpdateVersion(global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteVersion(global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Loads a specified version to draft version.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> LoadVersion(global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Versions</summary>
    public partial class VersionsClient : grpc::ClientBase<VersionsClient>
    {
      /// <summary>Creates a new client for Versions</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public VersionsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Versions that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public VersionsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected VersionsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected VersionsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse ListVersions(global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVersions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse ListVersions(global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListVersions, null, options, request);
      }
      /// <summary>
      /// Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse> ListVersionsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVersionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse> ListVersionsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListVersions, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Version GetVersion(global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetVersion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Version GetVersion(global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetVersion, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Version> GetVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetVersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Version> GetVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetVersion, null, options, request);
      }
      /// <summary>
      /// Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateVersion(global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateVersion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateVersion(global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateVersion, null, options, request);
      }
      /// <summary>
      /// Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateVersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateVersion, null, options, request);
      }
      /// <summary>
      /// Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Version UpdateVersion(global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateVersion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Version UpdateVersion(global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateVersion, null, options, request);
      }
      /// <summary>
      /// Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Version> UpdateVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateVersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Version> UpdateVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateVersion, null, options, request);
      }
      /// <summary>
      /// Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteVersion(global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteVersion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteVersion(global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteVersion, null, options, request);
      }
      /// <summary>
      /// Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteVersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteVersion, null, options, request);
      }
      /// <summary>
      /// Loads a specified version to draft version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation LoadVersion(global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoadVersion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Loads a specified version to draft version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation LoadVersion(global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LoadVersion, null, options, request);
      }
      /// <summary>
      /// Loads a specified version to draft version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> LoadVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoadVersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Loads a specified version to draft version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> LoadVersionAsync(global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LoadVersion, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override VersionsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new VersionsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(VersionsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListVersions, serviceImpl.ListVersions)
          .AddMethod(__Method_GetVersion, serviceImpl.GetVersion)
          .AddMethod(__Method_CreateVersion, serviceImpl.CreateVersion)
          .AddMethod(__Method_UpdateVersion, serviceImpl.UpdateVersion)
          .AddMethod(__Method_DeleteVersion, serviceImpl.DeleteVersion)
          .AddMethod(__Method_LoadVersion, serviceImpl.LoadVersion).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, VersionsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListVersions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListVersionsResponse>(serviceImpl.ListVersions));
      serviceBinder.AddMethod(__Method_GetVersion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version>(serviceImpl.GetVersion));
      serviceBinder.AddMethod(__Method_CreateVersion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.CreateVersionRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateVersion));
      serviceBinder.AddMethod(__Method_UpdateVersion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.UpdateVersionRequest, global::Google.Cloud.Dialogflow.Cx.V3.Version>(serviceImpl.UpdateVersion));
      serviceBinder.AddMethod(__Method_DeleteVersion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.DeleteVersionRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteVersion));
      serviceBinder.AddMethod(__Method_LoadVersion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.LoadVersionRequest, global::Google.LongRunning.Operation>(serviceImpl.LoadVersion));
    }

  }
}
#endregion
