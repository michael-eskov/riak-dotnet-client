//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: riak_search.proto
// Note: requires additional types generated from: riak.proto
namespace RiakClient.Messages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSearchDoc")]
  public partial class RpbSearchDoc : global::ProtoBuf.IExtensible
  {
    public RpbSearchDoc() {}
    
    private readonly global::System.Collections.Generic.List<RpbPair> _fields = new global::System.Collections.Generic.List<RpbPair>();
    [global::ProtoBuf.ProtoMember(1, Name=@"fields", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbPair> fields
    {
      get { return _fields; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSearchQueryReq")]
  public partial class RpbSearchQueryReq : global::ProtoBuf.IExtensible
  {
    public RpbSearchQueryReq() {}
    
    private byte[] _q;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"q", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] q
    {
      get { return _q; }
      set { _q = value; }
    }
    private byte[] _index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] index
    {
      get { return _index; }
      set { _index = value; }
    }
    private uint _rows = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rows
    {
      get { return _rows; }
      set { _rows = value; }
    }
    private uint _start = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint start
    {
      get { return _start; }
      set { _start = value; }
    }
    private byte[] _sort = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"sort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] sort
    {
      get { return _sort; }
      set { _sort = value; }
    }
    private byte[] _filter = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"filter", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] filter
    {
      get { return _filter; }
      set { _filter = value; }
    }
    private byte[] _df = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"df", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] df
    {
      get { return _df; }
      set { _df = value; }
    }
    private byte[] _op = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"op", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] op
    {
      get { return _op; }
      set { _op = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _fl = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(9, Name=@"fl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> fl
    {
      get { return _fl; }
    }
  
    private byte[] _presort = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"presort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] presort
    {
      get { return _presort; }
      set { _presort = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSearchQueryResp")]
  public partial class RpbSearchQueryResp : global::ProtoBuf.IExtensible
  {
    public RpbSearchQueryResp() {}
    
    private readonly global::System.Collections.Generic.List<RpbSearchDoc> _docs = new global::System.Collections.Generic.List<RpbSearchDoc>();
    [global::ProtoBuf.ProtoMember(1, Name=@"docs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbSearchDoc> docs
    {
      get { return _docs; }
    }
  
    private float _max_score = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"max_score", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float max_score
    {
      get { return _max_score; }
      set { _max_score = value; }
    }
    private uint _num_found = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num_found", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num_found
    {
      get { return _num_found; }
      set { _num_found = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}