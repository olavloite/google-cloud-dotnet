// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/resourcemanager/v3/tag_bindings.proto
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

namespace Google.Cloud.ResourceManager.V3 {
  /// <summary>
  /// Allow users to create and manage TagBindings between TagValues and
  /// different cloud resources throughout the GCP resource hierarchy.
  /// </summary>
  public static partial class TagBindings
  {
    static readonly string __ServiceName = "google.cloud.resourcemanager.v3.TagBindings";

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

    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest> __Marshaller_google_cloud_resourcemanager_v3_ListTagBindingsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse> __Marshaller_google_cloud_resourcemanager_v3_ListTagBindingsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest> __Marshaller_google_cloud_resourcemanager_v3_CreateTagBindingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest> __Marshaller_google_cloud_resourcemanager_v3_DeleteTagBindingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest.Parser));

    static readonly grpc::Method<global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest, global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse> __Method_ListTagBindings = new grpc::Method<global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest, global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListTagBindings",
        __Marshaller_google_cloud_resourcemanager_v3_ListTagBindingsRequest,
        __Marshaller_google_cloud_resourcemanager_v3_ListTagBindingsResponse);

    static readonly grpc::Method<global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest, global::Google.LongRunning.Operation> __Method_CreateTagBinding = new grpc::Method<global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateTagBinding",
        __Marshaller_google_cloud_resourcemanager_v3_CreateTagBindingRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest, global::Google.LongRunning.Operation> __Method_DeleteTagBinding = new grpc::Method<global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteTagBinding",
        __Marshaller_google_cloud_resourcemanager_v3_DeleteTagBindingRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ResourceManager.V3.TagBindingsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TagBindings</summary>
    [grpc::BindServiceMethod(typeof(TagBindings), "BindService")]
    public abstract partial class TagBindingsBase
    {
      /// <summary>
      /// Lists the TagBindings for the given cloud resource, as specified with
      /// `parent`.
      ///
      /// NOTE: The `parent` field is expected to be a full resource name:
      /// https://cloud.google.com/apis/design/resource_names#full_resource_name
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse> ListTagBindings(global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a TagBinding between a TagValue and a cloud resource
      /// (currently project, folder, or organization).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateTagBinding(global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a TagBinding.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteTagBinding(global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TagBindings</summary>
    public partial class TagBindingsClient : grpc::ClientBase<TagBindingsClient>
    {
      /// <summary>Creates a new client for TagBindings</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TagBindingsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TagBindings that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TagBindingsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TagBindingsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TagBindingsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists the TagBindings for the given cloud resource, as specified with
      /// `parent`.
      ///
      /// NOTE: The `parent` field is expected to be a full resource name:
      /// https://cloud.google.com/apis/design/resource_names#full_resource_name
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse ListTagBindings(global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTagBindings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the TagBindings for the given cloud resource, as specified with
      /// `parent`.
      ///
      /// NOTE: The `parent` field is expected to be a full resource name:
      /// https://cloud.google.com/apis/design/resource_names#full_resource_name
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse ListTagBindings(global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListTagBindings, null, options, request);
      }
      /// <summary>
      /// Lists the TagBindings for the given cloud resource, as specified with
      /// `parent`.
      ///
      /// NOTE: The `parent` field is expected to be a full resource name:
      /// https://cloud.google.com/apis/design/resource_names#full_resource_name
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse> ListTagBindingsAsync(global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTagBindingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the TagBindings for the given cloud resource, as specified with
      /// `parent`.
      ///
      /// NOTE: The `parent` field is expected to be a full resource name:
      /// https://cloud.google.com/apis/design/resource_names#full_resource_name
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse> ListTagBindingsAsync(global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListTagBindings, null, options, request);
      }
      /// <summary>
      /// Creates a TagBinding between a TagValue and a cloud resource
      /// (currently project, folder, or organization).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateTagBinding(global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTagBinding(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a TagBinding between a TagValue and a cloud resource
      /// (currently project, folder, or organization).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateTagBinding(global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateTagBinding, null, options, request);
      }
      /// <summary>
      /// Creates a TagBinding between a TagValue and a cloud resource
      /// (currently project, folder, or organization).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateTagBindingAsync(global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTagBindingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a TagBinding between a TagValue and a cloud resource
      /// (currently project, folder, or organization).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateTagBindingAsync(global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateTagBinding, null, options, request);
      }
      /// <summary>
      /// Deletes a TagBinding.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteTagBinding(global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteTagBinding(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a TagBinding.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteTagBinding(global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteTagBinding, null, options, request);
      }
      /// <summary>
      /// Deletes a TagBinding.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteTagBindingAsync(global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteTagBindingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a TagBinding.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteTagBindingAsync(global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteTagBinding, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TagBindingsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TagBindingsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TagBindingsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListTagBindings, serviceImpl.ListTagBindings)
          .AddMethod(__Method_CreateTagBinding, serviceImpl.CreateTagBinding)
          .AddMethod(__Method_DeleteTagBinding, serviceImpl.DeleteTagBinding).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TagBindingsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListTagBindings, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ResourceManager.V3.ListTagBindingsRequest, global::Google.Cloud.ResourceManager.V3.ListTagBindingsResponse>(serviceImpl.ListTagBindings));
      serviceBinder.AddMethod(__Method_CreateTagBinding, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ResourceManager.V3.CreateTagBindingRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateTagBinding));
      serviceBinder.AddMethod(__Method_DeleteTagBinding, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ResourceManager.V3.DeleteTagBindingRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteTagBinding));
    }

  }
}
#endregion
