// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common/types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Shoc.Core.Grpc {

  /// <summary>Holder for reflection information generated from common/types.proto</summary>
  public static partial class TypesReflection {

    #region Descriptor
    /// <summary>File descriptor for common/types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJjb21tb24vdHlwZXMucHJvdG8SD2FwaS5ncnBjLmNvbW1vbiK2AQoTR3Jw",
            "Y0Vycm9yRGVmaW5pdGlvbhIMCgRraW5kGAEgASgJEgwKBGNvZGUYAiABKAkS",
            "DwoHbWVzc2FnZRgDIAEoCRJCCgdwYXlsb2FkGAQgAygLMjEuYXBpLmdycGMu",
            "Y29tbW9uLkdycGNFcnJvckRlZmluaXRpb24uUGF5bG9hZEVudHJ5Gi4KDFBh",
            "eWxvYWRFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBQhGq",
            "Ag5TaG9jLkNvcmUuR3JwY2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Shoc.Core.Grpc.GrpcErrorDefinition), global::Shoc.Core.Grpc.GrpcErrorDefinition.Parser, new[]{ "Kind", "Code", "Message", "Payload" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GrpcErrorDefinition : pb::IMessage<GrpcErrorDefinition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GrpcErrorDefinition> _parser = new pb::MessageParser<GrpcErrorDefinition>(() => new GrpcErrorDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GrpcErrorDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Shoc.Core.Grpc.TypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GrpcErrorDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GrpcErrorDefinition(GrpcErrorDefinition other) : this() {
      kind_ = other.kind_;
      code_ = other.code_;
      message_ = other.message_;
      payload_ = other.payload_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GrpcErrorDefinition Clone() {
      return new GrpcErrorDefinition(this);
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 1;
    private string kind_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Kind {
      get { return kind_; }
      set {
        kind_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 2;
    private string code_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Code {
      get { return code_; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_payload_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 34);
    private readonly pbc::MapField<string, string> payload_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Payload {
      get { return payload_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GrpcErrorDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GrpcErrorDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Kind != other.Kind) return false;
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      if (!Payload.Equals(other.Payload)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Kind.Length != 0) hash ^= Kind.GetHashCode();
      if (Code.Length != 0) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      hash ^= Payload.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Kind.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Kind);
      }
      if (Code.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      payload_.WriteTo(output, _map_payload_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Kind.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Kind);
      }
      if (Code.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      payload_.WriteTo(ref output, _map_payload_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Kind.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kind);
      }
      if (Code.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      size += payload_.CalculateSize(_map_payload_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GrpcErrorDefinition other) {
      if (other == null) {
        return;
      }
      if (other.Kind.Length != 0) {
        Kind = other.Kind;
      }
      if (other.Code.Length != 0) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      payload_.Add(other.payload_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Kind = input.ReadString();
            break;
          }
          case 18: {
            Code = input.ReadString();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 34: {
            payload_.AddEntriesFrom(input, _map_payload_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Kind = input.ReadString();
            break;
          }
          case 18: {
            Code = input.ReadString();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 34: {
            payload_.AddEntriesFrom(ref input, _map_payload_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
