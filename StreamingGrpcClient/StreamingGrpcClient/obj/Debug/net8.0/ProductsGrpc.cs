// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: products.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductServices.Streaming.Demo {
  public static partial class ProductService
  {
    static readonly string __ServiceName = "ProductStreamingDemo.ProductService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductServices.Streaming.Demo.ProductListing> __Marshaller_ProductStreamingDemo_ProductListing = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductServices.Streaming.Demo.ProductListing.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductServices.Streaming.Demo.DetailsInput> __Marshaller_ProductStreamingDemo_DetailsInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductServices.Streaming.Demo.DetailsInput.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductServices.Streaming.Demo.Product> __Marshaller_ProductStreamingDemo_Product = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductServices.Streaming.Demo.Product.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductServices.Streaming.Demo.ProductListing> __Method_UnaryProductListing = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductServices.Streaming.Demo.ProductListing>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnaryProductListing",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ProductStreamingDemo_ProductListing);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product> __Method_UnaryGetProductDetails = new grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnaryGetProductDetails",
        __Marshaller_ProductStreamingDemo_DetailsInput,
        __Marshaller_ProductStreamingDemo_Product);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductServices.Streaming.Demo.ProductListing> __Method_GetProductListSS = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductServices.Streaming.Demo.ProductListing>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetProductListSS",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ProductStreamingDemo_ProductListing);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.ProductListing> __Method_GetProductListCS = new grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.ProductListing>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "GetProductListCS",
        __Marshaller_ProductStreamingDemo_DetailsInput,
        __Marshaller_ProductStreamingDemo_ProductListing);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product> __Method_GetProductsBoth = new grpc::Method<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetProductsBoth",
        __Marshaller_ProductStreamingDemo_DetailsInput,
        __Marshaller_ProductStreamingDemo_Product);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductServices.Streaming.Demo.ProductsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ProductService</summary>
    public partial class ProductServiceClient : grpc::ClientBase<ProductServiceClient>
    {
      /// <summary>Creates a new client for ProductService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductServices.Streaming.Demo.ProductListing UnaryProductListing(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnaryProductListing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductServices.Streaming.Demo.ProductListing UnaryProductListing(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UnaryProductListing, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductServices.Streaming.Demo.ProductListing> UnaryProductListingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnaryProductListingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductServices.Streaming.Demo.ProductListing> UnaryProductListingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UnaryProductListing, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductServices.Streaming.Demo.Product UnaryGetProductDetails(global::ProductServices.Streaming.Demo.DetailsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnaryGetProductDetails(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductServices.Streaming.Demo.Product UnaryGetProductDetails(global::ProductServices.Streaming.Demo.DetailsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UnaryGetProductDetails, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductServices.Streaming.Demo.Product> UnaryGetProductDetailsAsync(global::ProductServices.Streaming.Demo.DetailsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnaryGetProductDetailsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductServices.Streaming.Demo.Product> UnaryGetProductDetailsAsync(global::ProductServices.Streaming.Demo.DetailsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UnaryGetProductDetails, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::ProductServices.Streaming.Demo.ProductListing> GetProductListSS(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductListSS(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::ProductServices.Streaming.Demo.ProductListing> GetProductListSS(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetProductListSS, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.ProductListing> GetProductListCS(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductListCS(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.ProductListing> GetProductListCS(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_GetProductListCS, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product> GetProductsBoth(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductsBoth(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::ProductServices.Streaming.Demo.DetailsInput, global::ProductServices.Streaming.Demo.Product> GetProductsBoth(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetProductsBoth, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductServiceClient(configuration);
      }
    }

  }
}
#endregion
