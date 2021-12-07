// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tgams.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BenGrewell.Tgams {

  /// <summary>Holder for reflection information generated from tgams.proto</summary>
  public static partial class TgamsReflection {

    #region Descriptor
    /// <summary>File descriptor for tgams.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TgamsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgt0Z2Ftcy5wcm90byIhCgtQaW5nUmVxdWVzdBISCgpyZXF1ZXN0X2lkGAEg",
            "ASgEIrMBCgxQaW5nUmVzcG9uc2USEwoLcmVzcG9uc2VfaWQYASABKAQSEgoK",
            "cmVxdWVzdF9pZBgCIAEoBBIoCgZzdGF0dXMYAyABKA4yGC5QaW5nUmVzcG9u",
            "c2UuUGluZ1N0YXR1cyJQCgpQaW5nU3RhdHVzEgYKAk9LEAASDAoIU1RBUlRJ",
            "TkcQARIMCghTVE9QUElORxACEgkKBVJFQURZEAMSCAoEQlVTWRAEEgkKBUVS",
            "Uk9SEAUiMQoPVGltZVN5bmNSZXF1ZXN0EhIKCnJlcXVlc3RfaWQYASABKAQS",
            "CgoCdDEYAiABKAMiawoQVGltZVN5bmNSZXNwb25zZRITCgtyZXNwb25zZV9p",
            "ZBgBIAEoBBISCgpyZXF1ZXN0X2lkGAIgASgEEgoKAnQxGAogASgDEgoKAnQy",
            "GAsgASgDEgoKAnQzGAwgASgDEgoKAnQ0GA0gASgDMhAKDkNvbnRyb2xDaGFu",
            "bmVsMhIKEFRlbGVtZXRyeUNoYW5uZWxCNVogZ2l0aHViLmNvbS9CR3Jld2Vs",
            "bC90Z2Ftcy9hcGkvZ2+qAhBCZW5HcmV3ZWxsLlRnYW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BenGrewell.Tgams.PingRequest), global::BenGrewell.Tgams.PingRequest.Parser, new[]{ "RequestId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BenGrewell.Tgams.PingResponse), global::BenGrewell.Tgams.PingResponse.Parser, new[]{ "ResponseId", "RequestId", "Status" }, null, new[]{ typeof(global::BenGrewell.Tgams.PingResponse.Types.PingStatus) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BenGrewell.Tgams.TimeSyncRequest), global::BenGrewell.Tgams.TimeSyncRequest.Parser, new[]{ "RequestId", "T1" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BenGrewell.Tgams.TimeSyncResponse), global::BenGrewell.Tgams.TimeSyncResponse.Parser, new[]{ "ResponseId", "RequestId", "T1", "T2", "T3", "T4" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PingRequest : pb::IMessage<PingRequest> {
    private static readonly pb::MessageParser<PingRequest> _parser = new pb::MessageParser<PingRequest>(() => new PingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BenGrewell.Tgams.TgamsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest(PingRequest other) : this() {
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest Clone() {
      return new PingRequest(this);
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 1;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
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
      if (RequestId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(RequestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingRequest other) {
      if (other == null) {
        return;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
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
          case 8: {
            RequestId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PingResponse : pb::IMessage<PingResponse> {
    private static readonly pb::MessageParser<PingResponse> _parser = new pb::MessageParser<PingResponse>(() => new PingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BenGrewell.Tgams.TgamsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingResponse(PingResponse other) : this() {
      responseId_ = other.responseId_;
      requestId_ = other.requestId_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingResponse Clone() {
      return new PingResponse(this);
    }

    /// <summary>Field number for the "response_id" field.</summary>
    public const int ResponseIdFieldNumber = 1;
    private ulong responseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ResponseId {
      get { return responseId_; }
      set {
        responseId_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 2;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::BenGrewell.Tgams.PingResponse.Types.PingStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BenGrewell.Tgams.PingResponse.Types.PingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResponseId != other.ResponseId) return false;
      if (RequestId != other.RequestId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResponseId != 0UL) hash ^= ResponseId.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (ResponseId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ResponseId);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(RequestId);
      }
      if (Status != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResponseId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ResponseId);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResponseId != 0UL) {
        ResponseId = other.ResponseId;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
          case 8: {
            ResponseId = input.ReadUInt64();
            break;
          }
          case 16: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 24: {
            status_ = (global::BenGrewell.Tgams.PingResponse.Types.PingStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PingResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PingStatus {
        [pbr::OriginalName("OK")] Ok = 0,
        [pbr::OriginalName("STARTING")] Starting = 1,
        [pbr::OriginalName("STOPPING")] Stopping = 2,
        [pbr::OriginalName("READY")] Ready = 3,
        [pbr::OriginalName("BUSY")] Busy = 4,
        [pbr::OriginalName("ERROR")] Error = 5,
      }

    }
    #endregion

  }

  public sealed partial class TimeSyncRequest : pb::IMessage<TimeSyncRequest> {
    private static readonly pb::MessageParser<TimeSyncRequest> _parser = new pb::MessageParser<TimeSyncRequest>(() => new TimeSyncRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeSyncRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BenGrewell.Tgams.TgamsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncRequest(TimeSyncRequest other) : this() {
      requestId_ = other.requestId_;
      t1_ = other.t1_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncRequest Clone() {
      return new TimeSyncRequest(this);
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 1;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "t1" field.</summary>
    public const int T1FieldNumber = 2;
    private long t1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long T1 {
      get { return t1_; }
      set {
        t1_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeSyncRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeSyncRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestId != other.RequestId) return false;
      if (T1 != other.T1) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      if (T1 != 0L) hash ^= T1.GetHashCode();
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
      if (RequestId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(RequestId);
      }
      if (T1 != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(T1);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (T1 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(T1);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeSyncRequest other) {
      if (other == null) {
        return;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      if (other.T1 != 0L) {
        T1 = other.T1;
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
          case 8: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 16: {
            T1 = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TimeSyncResponse : pb::IMessage<TimeSyncResponse> {
    private static readonly pb::MessageParser<TimeSyncResponse> _parser = new pb::MessageParser<TimeSyncResponse>(() => new TimeSyncResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeSyncResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BenGrewell.Tgams.TgamsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncResponse(TimeSyncResponse other) : this() {
      responseId_ = other.responseId_;
      requestId_ = other.requestId_;
      t1_ = other.t1_;
      t2_ = other.t2_;
      t3_ = other.t3_;
      t4_ = other.t4_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSyncResponse Clone() {
      return new TimeSyncResponse(this);
    }

    /// <summary>Field number for the "response_id" field.</summary>
    public const int ResponseIdFieldNumber = 1;
    private ulong responseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ResponseId {
      get { return responseId_; }
      set {
        responseId_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 2;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "t1" field.</summary>
    public const int T1FieldNumber = 10;
    private long t1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long T1 {
      get { return t1_; }
      set {
        t1_ = value;
      }
    }

    /// <summary>Field number for the "t2" field.</summary>
    public const int T2FieldNumber = 11;
    private long t2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long T2 {
      get { return t2_; }
      set {
        t2_ = value;
      }
    }

    /// <summary>Field number for the "t3" field.</summary>
    public const int T3FieldNumber = 12;
    private long t3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long T3 {
      get { return t3_; }
      set {
        t3_ = value;
      }
    }

    /// <summary>Field number for the "t4" field.</summary>
    public const int T4FieldNumber = 13;
    private long t4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long T4 {
      get { return t4_; }
      set {
        t4_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeSyncResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeSyncResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResponseId != other.ResponseId) return false;
      if (RequestId != other.RequestId) return false;
      if (T1 != other.T1) return false;
      if (T2 != other.T2) return false;
      if (T3 != other.T3) return false;
      if (T4 != other.T4) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResponseId != 0UL) hash ^= ResponseId.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      if (T1 != 0L) hash ^= T1.GetHashCode();
      if (T2 != 0L) hash ^= T2.GetHashCode();
      if (T3 != 0L) hash ^= T3.GetHashCode();
      if (T4 != 0L) hash ^= T4.GetHashCode();
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
      if (ResponseId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ResponseId);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(RequestId);
      }
      if (T1 != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(T1);
      }
      if (T2 != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(T2);
      }
      if (T3 != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(T3);
      }
      if (T4 != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(T4);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResponseId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ResponseId);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (T1 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(T1);
      }
      if (T2 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(T2);
      }
      if (T3 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(T3);
      }
      if (T4 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(T4);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeSyncResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResponseId != 0UL) {
        ResponseId = other.ResponseId;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      if (other.T1 != 0L) {
        T1 = other.T1;
      }
      if (other.T2 != 0L) {
        T2 = other.T2;
      }
      if (other.T3 != 0L) {
        T3 = other.T3;
      }
      if (other.T4 != 0L) {
        T4 = other.T4;
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
          case 8: {
            ResponseId = input.ReadUInt64();
            break;
          }
          case 16: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 80: {
            T1 = input.ReadInt64();
            break;
          }
          case 88: {
            T2 = input.ReadInt64();
            break;
          }
          case 96: {
            T3 = input.ReadInt64();
            break;
          }
          case 104: {
            T4 = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
