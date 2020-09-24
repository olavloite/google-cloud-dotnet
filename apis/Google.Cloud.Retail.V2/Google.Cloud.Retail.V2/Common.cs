// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/retail/v2/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Retail.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/retail/v2/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/retail/v2/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNnb29nbGUvY2xvdWQvcmV0YWlsL3YyL2NvbW1vbi5wcm90bxIWZ29vZ2xl",
            "LmNsb3VkLnJldGFpbC52MhocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxofZ29vZ2xlL3By",
            "b3RvYnVmL3RpbWVzdGFtcC5wcm90byIwCg9DdXN0b21BdHRyaWJ1dGUSDAoE",
            "dGV4dBgBIAMoCRIPCgdudW1iZXJzGAIgAygBIjgKBUltYWdlEhAKA3VyaRgB",
            "IAEoCUID4EECEg4KBmhlaWdodBgCIAEoBRINCgV3aWR0aBgDIAEoBSJXCglQ",
            "cmljZUluZm8SFQoNY3VycmVuY3lfY29kZRgBIAEoCRINCgVwcmljZRgCIAEo",
            "AhIWCg5vcmlnaW5hbF9wcmljZRgDIAEoAhIMCgRjb3N0GAQgASgCImAKCFVz",
            "ZXJJbmZvEg8KB3VzZXJfaWQYASABKAkSEgoKaXBfYWRkcmVzcxgCIAEoCRIS",
            "Cgp1c2VyX2FnZW50GAMgASgJEhsKE2RpcmVjdF91c2VyX3JlcXVlc3QYBCAB",
            "KAhCwAEKGmNvbS5nb29nbGUuY2xvdWQucmV0YWlsLnYyQgtDb21tb25Qcm90",
            "b1ABWjxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL3JldGFpbC92MjtyZXRhaWyiAgZSRVRBSUyqAhZHb29nbGUuQ2xvdWQu",
            "UmV0YWlsLlYyygIWR29vZ2xlXENsb3VkXFJldGFpbFxWMuoCGUdvb2dsZTo6",
            "Q2xvdWQ6OlJldGFpbDo6VjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2.CustomAttribute), global::Google.Cloud.Retail.V2.CustomAttribute.Parser, new[]{ "Text", "Numbers" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2.Image), global::Google.Cloud.Retail.V2.Image.Parser, new[]{ "Uri", "Height", "Width" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2.PriceInfo), global::Google.Cloud.Retail.V2.PriceInfo.Parser, new[]{ "CurrencyCode", "Price", "OriginalPrice", "Cost" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2.UserInfo), global::Google.Cloud.Retail.V2.UserInfo.Parser, new[]{ "UserId", "IpAddress", "UserAgent", "DirectUserRequest" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A custom attribute that is not explicitly modeled in
  /// [Product][google.cloud.retail.v2.Product]].
  /// </summary>
  public sealed partial class CustomAttribute : pb::IMessage<CustomAttribute> {
    private static readonly pb::MessageParser<CustomAttribute> _parser = new pb::MessageParser<CustomAttribute>(() => new CustomAttribute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomAttribute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomAttribute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomAttribute(CustomAttribute other) : this() {
      text_ = other.text_.Clone();
      numbers_ = other.numbers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomAttribute Clone() {
      return new CustomAttribute(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_text_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> text_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The textual values of this custom attribute. For example, `["yellow",
    /// "green"]` when the key is "color".
    ///
    /// At most 400 values are allowed. Empty values are not allowed. Each value
    /// must be a UTF-8 encoded string with a length limit of 256 bytes. Otherwise,
    /// an INVALID_ARGUMENT error is returned.
    ///
    /// Exactly one of [text][google.cloud.retail.v2.CustomAttribute.text] or
    /// [numbers][google.cloud.retail.v2.CustomAttribute.numbers] should be set.
    /// Otherwise, a FAILED_PRECONDITION error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Text {
      get { return text_; }
    }

    /// <summary>Field number for the "numbers" field.</summary>
    public const int NumbersFieldNumber = 2;
    private static readonly pb::FieldCodec<double> _repeated_numbers_codec
        = pb::FieldCodec.ForDouble(18);
    private readonly pbc::RepeatedField<double> numbers_ = new pbc::RepeatedField<double>();
    /// <summary>
    /// The numerical values of this custom attribute. For example, `[2.3, 15.4]`
    /// when the key is "lengths_cm".
    ///
    /// At most 400 values are allowed.Otherwise, an INVALID_ARGUMENT error is
    /// returned.
    ///
    /// Exactly one of [text][google.cloud.retail.v2.CustomAttribute.text] or
    /// [numbers][google.cloud.retail.v2.CustomAttribute.numbers] should be set.
    /// Otherwise, a FAILED_PRECONDITION error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> Numbers {
      get { return numbers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomAttribute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomAttribute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!text_.Equals(other.text_)) return false;
      if(!numbers_.Equals(other.numbers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= text_.GetHashCode();
      hash ^= numbers_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      text_.WriteTo(output, _repeated_text_codec);
      numbers_.WriteTo(output, _repeated_numbers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += text_.CalculateSize(_repeated_text_codec);
      size += numbers_.CalculateSize(_repeated_numbers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomAttribute other) {
      if (other == null) {
        return;
      }
      text_.Add(other.text_);
      numbers_.Add(other.numbers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            text_.AddEntriesFrom(input, _repeated_text_codec);
            break;
          }
          case 18:
          case 17: {
            numbers_.AddEntriesFrom(input, _repeated_numbers_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// [Product][google.cloud.retail.v2.Product] thumbnail/detail image.
  /// </summary>
  public sealed partial class Image : pb::IMessage<Image> {
    private static readonly pb::MessageParser<Image> _parser = new pb::MessageParser<Image>(() => new Image());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Image> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image(Image other) : this() {
      uri_ = other.uri_;
      height_ = other.height_;
      width_ = other.width_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image Clone() {
      return new Image(this);
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 1;
    private string uri_ = "";
    /// <summary>
    /// Required. URI of the image.
    ///
    /// This field must be a valid UTF-8 encoded URI with a length limit of 5 KiB.
    /// Otherwise, an INVALID_ARGUMENT error is returned.
    ///
    /// Google Merchant Center property
    /// [image_link](https://support.google.com/merchants/answer/6324350).
    /// Schema.org property [Product.image](http://schema.org/image).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 2;
    private int height_;
    /// <summary>
    /// Height of the image in number of pixels.
    ///
    /// This field must be nonnegative. Otherwise, an INVALID_ARGUMENT error is
    /// returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 3;
    private int width_;
    /// <summary>
    /// Width of the image in number of pixels.
    ///
    /// This field must be nonnegative. Otherwise, an INVALID_ARGUMENT error is
    /// returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Image);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Image other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uri != other.Uri) return false;
      if (Height != other.Height) return false;
      if (Width != other.Width) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (Width != 0) hash ^= Width.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (Height != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Height);
      }
      if (Width != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Width);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Image other) {
      if (other == null) {
        return;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Uri = input.ReadString();
            break;
          }
          case 16: {
            Height = input.ReadInt32();
            break;
          }
          case 24: {
            Width = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The price information of a [Product][google.cloud.retail.v2.Product].
  /// </summary>
  public sealed partial class PriceInfo : pb::IMessage<PriceInfo> {
    private static readonly pb::MessageParser<PriceInfo> _parser = new pb::MessageParser<PriceInfo>(() => new PriceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2.CommonReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceInfo(PriceInfo other) : this() {
      currencyCode_ = other.currencyCode_;
      price_ = other.price_;
      originalPrice_ = other.originalPrice_;
      cost_ = other.cost_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceInfo Clone() {
      return new PriceInfo(this);
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 1;
    private string currencyCode_ = "";
    /// <summary>
    /// The 3-letter currency code defined in [ISO
    /// 4217][https://www.iso.org/iso-4217-currency-codes.html].
    ///
    /// If this field is an unrecognizable currency code, an INVALID_ARGUMENT
    /// error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 2;
    private float price_;
    /// <summary>
    /// Price of the product.
    ///
    /// Google Merchant Center property
    /// [price](https://support.google.com/merchants/answer/6324371).
    /// Schema.org property
    /// [Offer.priceSpecification](https://schema.org/priceSpecification).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "original_price" field.</summary>
    public const int OriginalPriceFieldNumber = 3;
    private float originalPrice_;
    /// <summary>
    /// Price of the product without any discount. If zero, by default set to be
    /// the [price][google.cloud.retail.v2.PriceInfo.price].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float OriginalPrice {
      get { return originalPrice_; }
      set {
        originalPrice_ = value;
      }
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 4;
    private float cost_;
    /// <summary>
    /// The costs associated with the sale of a particular product. Used for gross
    /// profit reporting.
    ///
    /// * Profit = [price][google.cloud.retail.v2.PriceInfo.price] -
    /// [cost][google.cloud.retail.v2.PriceInfo.cost]
    ///
    /// Google Merchant Center property
    /// [cost_of_goods_sold](https://support.google.com/merchants/answer/9017895)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Cost {
      get { return cost_; }
      set {
        cost_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrencyCode != other.CurrencyCode) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Price, other.Price)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OriginalPrice, other.OriginalPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Cost, other.Cost)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
      if (Price != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Price);
      if (OriginalPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OriginalPrice);
      if (Cost != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Cost);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrencyCode);
      }
      if (Price != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Price);
      }
      if (OriginalPrice != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(OriginalPrice);
      }
      if (Cost != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Cost);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrencyCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (Price != 0F) {
        size += 1 + 4;
      }
      if (OriginalPrice != 0F) {
        size += 1 + 4;
      }
      if (Cost != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PriceInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurrencyCode.Length != 0) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.Price != 0F) {
        Price = other.Price;
      }
      if (other.OriginalPrice != 0F) {
        OriginalPrice = other.OriginalPrice;
      }
      if (other.Cost != 0F) {
        Cost = other.Cost;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 21: {
            Price = input.ReadFloat();
            break;
          }
          case 29: {
            OriginalPrice = input.ReadFloat();
            break;
          }
          case 37: {
            Cost = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Information of an end user.
  /// </summary>
  public sealed partial class UserInfo : pb::IMessage<UserInfo> {
    private static readonly pb::MessageParser<UserInfo> _parser = new pb::MessageParser<UserInfo>(() => new UserInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2.CommonReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo(UserInfo other) : this() {
      userId_ = other.userId_;
      ipAddress_ = other.ipAddress_;
      userAgent_ = other.userAgent_;
      directUserRequest_ = other.directUserRequest_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo Clone() {
      return new UserInfo(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    /// <summary>
    /// Highly recommended for logged-in users. Unique identifier for logged-in
    /// user, such as a user name.
    ///
    /// The field must be a UTF-8 encoded string with a length limit of 128 bytes.
    /// Otherwise, an INVALID_ARGUMENT error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ip_address" field.</summary>
    public const int IpAddressFieldNumber = 2;
    private string ipAddress_ = "";
    /// <summary>
    /// The end user's IP address. This field is used to extract location
    /// information for personalization.
    ///
    /// This field must be either an IPv4 address (e.g. "104.133.9.80") or an IPv6
    /// address (e.g. "2001:0db8:85a3:0000:0000:8a2e:0370:7334"). Otherwise, an
    /// INVALID_ARGUMENT error is returned.
    ///
    /// This should not be set when using the JavaScript tag in
    /// [UserEventService.CollectUserEvent][google.cloud.retail.v2.UserEventService.CollectUserEvent]
    /// or if
    /// [direct_user_request][google.cloud.retail.v2.UserInfo.direct_user_request]
    /// is set. Otherwise, a FAILED_PRECONDITION error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IpAddress {
      get { return ipAddress_; }
      set {
        ipAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_agent" field.</summary>
    public const int UserAgentFieldNumber = 3;
    private string userAgent_ = "";
    /// <summary>
    /// User agent as included in the HTTP header.
    ///
    /// The field must be a UTF-8 encoded string with a length limit of 1 KiB.
    /// Otherwise, an INVALID_ARGUMENT error is returned.
    ///
    /// This should not be set when using the client side event reporting with
    /// GTM or JavaScript tag in
    /// [UserEventService.CollectUserEvent][google.cloud.retail.v2.UserEventService.CollectUserEvent]
    /// or if
    /// [direct_user_request][google.cloud.retail.v2.UserInfo.direct_user_request]
    /// is set. Otherwise, a FAILED_PRECONDITION error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserAgent {
      get { return userAgent_; }
      set {
        userAgent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "direct_user_request" field.</summary>
    public const int DirectUserRequestFieldNumber = 4;
    private bool directUserRequest_;
    /// <summary>
    /// True if the request is made directly from the end user, in which case the
    /// [ip_address][google.cloud.retail.v2.UserInfo.ip_address] and
    /// [user_agent][google.cloud.retail.v2.UserInfo.user_agent] can be populated
    /// from the HTTP request. This flag should be set only if the API request is
    /// made directly from the end user such as a mobile app (and not if a gateway
    /// or a server is processing and pushing the user events).
    ///
    /// This should not be set when using the JavaScript tag in
    /// [UserEventService.CollectUserEvent][google.cloud.retail.v2.UserEventService.CollectUserEvent].
    /// Otherwise, a FAILED_PRECONDITION error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DirectUserRequest {
      get { return directUserRequest_; }
      set {
        directUserRequest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (IpAddress != other.IpAddress) return false;
      if (UserAgent != other.UserAgent) return false;
      if (DirectUserRequest != other.DirectUserRequest) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (IpAddress.Length != 0) hash ^= IpAddress.GetHashCode();
      if (UserAgent.Length != 0) hash ^= UserAgent.GetHashCode();
      if (DirectUserRequest != false) hash ^= DirectUserRequest.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (IpAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(IpAddress);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserAgent);
      }
      if (DirectUserRequest != false) {
        output.WriteRawTag(32);
        output.WriteBool(DirectUserRequest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (IpAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IpAddress);
      }
      if (UserAgent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserAgent);
      }
      if (DirectUserRequest != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserInfo other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.IpAddress.Length != 0) {
        IpAddress = other.IpAddress;
      }
      if (other.UserAgent.Length != 0) {
        UserAgent = other.UserAgent;
      }
      if (other.DirectUserRequest != false) {
        DirectUserRequest = other.DirectUserRequest;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
          case 18: {
            IpAddress = input.ReadString();
            break;
          }
          case 26: {
            UserAgent = input.ReadString();
            break;
          }
          case 32: {
            DirectUserRequest = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code