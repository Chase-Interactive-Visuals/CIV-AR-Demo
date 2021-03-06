// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ror.schema.upload
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct GCSSignedComposeURL : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static GCSSignedComposeURL GetRootAsGCSSignedComposeURL(ByteBuffer _bb) { return GetRootAsGCSSignedComposeURL(_bb, new GCSSignedComposeURL()); }
  public static GCSSignedComposeURL GetRootAsGCSSignedComposeURL(ByteBuffer _bb, GCSSignedComposeURL obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GCSSignedComposeURL __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ror.schema.upload.GCSSignedAuth? ComposeAuth { get { int o = __p.__offset(4); return o != 0 ? (ror.schema.upload.GCSSignedAuth?)(new ror.schema.upload.GCSSignedAuth()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<ror.schema.upload.GCSSignedComposeURL> CreateGCSSignedComposeURL(FlatBufferBuilder builder,
      Offset<ror.schema.upload.GCSSignedAuth> composeAuthOffset = default(Offset<ror.schema.upload.GCSSignedAuth>)) {
    builder.StartTable(1);
    GCSSignedComposeURL.AddComposeAuth(builder, composeAuthOffset);
    return GCSSignedComposeURL.EndGCSSignedComposeURL(builder);
  }

  public static void StartGCSSignedComposeURL(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddComposeAuth(FlatBufferBuilder builder, Offset<ror.schema.upload.GCSSignedAuth> composeAuthOffset) { builder.AddOffset(0, composeAuthOffset.Value, 0); }
  public static Offset<ror.schema.upload.GCSSignedComposeURL> EndGCSSignedComposeURL(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ror.schema.upload.GCSSignedComposeURL>(o);
  }
  public GCSSignedComposeURLT UnPack() {
    var _o = new GCSSignedComposeURLT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GCSSignedComposeURLT _o) {
    _o.ComposeAuth = this.ComposeAuth.HasValue ? this.ComposeAuth.Value.UnPack() : null;
  }
  public static Offset<ror.schema.upload.GCSSignedComposeURL> Pack(FlatBufferBuilder builder, GCSSignedComposeURLT _o) {
    if (_o == null) return default(Offset<ror.schema.upload.GCSSignedComposeURL>);
    var _composeAuth = _o.ComposeAuth == null ? default(Offset<ror.schema.upload.GCSSignedAuth>) : ror.schema.upload.GCSSignedAuth.Pack(builder, _o.ComposeAuth);
    return CreateGCSSignedComposeURL(
      builder,
      _composeAuth);
  }
};

public class GCSSignedComposeURLT
{
  public ror.schema.upload.GCSSignedAuthT ComposeAuth { get; set; }

  public GCSSignedComposeURLT() {
    this.ComposeAuth = null;
  }
}


}
