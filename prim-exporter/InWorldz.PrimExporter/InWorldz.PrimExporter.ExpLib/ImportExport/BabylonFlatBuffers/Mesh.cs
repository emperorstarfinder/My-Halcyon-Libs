// automatically generated by the FlatBuffers compiler, do not modify

namespace InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers
{

using System;
using FlatBuffers;

public struct Mesh : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Mesh GetRootAsMesh(ByteBuffer _bb) { return GetRootAsMesh(_bb, new Mesh()); }
  public static Mesh GetRootAsMesh(ByteBuffer _bb, Mesh obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Mesh __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Id { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public string ParentId { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetParentIdBytes() { return __p.__vector_as_arraysegment(8); }
  public string MaterialId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetMaterialIdBytes() { return __p.__vector_as_arraysegment(10); }
  public float Position(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int PositionLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetPositionBytes() { return __p.__vector_as_arraysegment(12); }
  public float RotationQuaternion(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int RotationQuaternionLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetRotationQuaternionBytes() { return __p.__vector_as_arraysegment(14); }
  public float Scaling(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ScalingLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetScalingBytes() { return __p.__vector_as_arraysegment(16); }
  public float Positions(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int PositionsLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetPositionsBytes() { return __p.__vector_as_arraysegment(18); }
  public float Normals(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int NormalsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetNormalsBytes() { return __p.__vector_as_arraysegment(20); }
  public float Uvs(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int UvsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetUvsBytes() { return __p.__vector_as_arraysegment(22); }
  public ushort Indices(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetUshort(__p.__vector(o) + j * 2) : (ushort)0; }
  public int IndicesLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIndicesBytes() { return __p.__vector_as_arraysegment(24); }
  public InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.SubMesh? Submeshes(int j) { int o = __p.__offset(26); return o != 0 ? (InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.SubMesh?)(new InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.SubMesh()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int SubmeshesLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance? Instances(int j) { int o = __p.__offset(28); return o != 0 ? (InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance?)(new InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int InstancesLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Mesh> CreateMesh(FlatBufferBuilder builder,
      StringOffset idOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      StringOffset parentIdOffset = default(StringOffset),
      StringOffset materialIdOffset = default(StringOffset),
      VectorOffset positionOffset = default(VectorOffset),
      VectorOffset rotationQuaternionOffset = default(VectorOffset),
      VectorOffset scalingOffset = default(VectorOffset),
      VectorOffset positionsOffset = default(VectorOffset),
      VectorOffset normalsOffset = default(VectorOffset),
      VectorOffset uvsOffset = default(VectorOffset),
      VectorOffset indicesOffset = default(VectorOffset),
      VectorOffset submeshesOffset = default(VectorOffset),
      VectorOffset instancesOffset = default(VectorOffset)) {
    builder.StartObject(13);
    Mesh.AddInstances(builder, instancesOffset);
    Mesh.AddSubmeshes(builder, submeshesOffset);
    Mesh.AddIndices(builder, indicesOffset);
    Mesh.AddUvs(builder, uvsOffset);
    Mesh.AddNormals(builder, normalsOffset);
    Mesh.AddPositions(builder, positionsOffset);
    Mesh.AddScaling(builder, scalingOffset);
    Mesh.AddRotationQuaternion(builder, rotationQuaternionOffset);
    Mesh.AddPosition(builder, positionOffset);
    Mesh.AddMaterialId(builder, materialIdOffset);
    Mesh.AddParentId(builder, parentIdOffset);
    Mesh.AddName(builder, nameOffset);
    Mesh.AddId(builder, idOffset);
    return Mesh.EndMesh(builder);
  }

  public static void StartMesh(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, StringOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddParentId(FlatBufferBuilder builder, StringOffset parentIdOffset) { builder.AddOffset(2, parentIdOffset.Value, 0); }
  public static void AddMaterialId(FlatBufferBuilder builder, StringOffset materialIdOffset) { builder.AddOffset(3, materialIdOffset.Value, 0); }
  public static void AddPosition(FlatBufferBuilder builder, VectorOffset positionOffset) { builder.AddOffset(4, positionOffset.Value, 0); }
  public static VectorOffset CreatePositionVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartPositionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotationQuaternion(FlatBufferBuilder builder, VectorOffset rotationQuaternionOffset) { builder.AddOffset(5, rotationQuaternionOffset.Value, 0); }
  public static VectorOffset CreateRotationQuaternionVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartRotationQuaternionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScaling(FlatBufferBuilder builder, VectorOffset scalingOffset) { builder.AddOffset(6, scalingOffset.Value, 0); }
  public static VectorOffset CreateScalingVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartScalingVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset) { builder.AddOffset(7, positionsOffset.Value, 0); }
  public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartPositionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNormals(FlatBufferBuilder builder, VectorOffset normalsOffset) { builder.AddOffset(8, normalsOffset.Value, 0); }
  public static VectorOffset CreateNormalsVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartNormalsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUvs(FlatBufferBuilder builder, VectorOffset uvsOffset) { builder.AddOffset(9, uvsOffset.Value, 0); }
  public static VectorOffset CreateUvsVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartUvsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIndices(FlatBufferBuilder builder, VectorOffset indicesOffset) { builder.AddOffset(10, indicesOffset.Value, 0); }
  public static VectorOffset CreateIndicesVector(FlatBufferBuilder builder, ushort[] data) { builder.StartVector(2, data.Length, 2); for (int i = data.Length - 1; i >= 0; i--) builder.AddUshort(data[i]); return builder.EndVector(); }
  public static void StartIndicesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(2, numElems, 2); }
  public static void AddSubmeshes(FlatBufferBuilder builder, VectorOffset submeshesOffset) { builder.AddOffset(11, submeshesOffset.Value, 0); }
  public static VectorOffset CreateSubmeshesVector(FlatBufferBuilder builder, Offset<InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.SubMesh>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartSubmeshesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInstances(FlatBufferBuilder builder, VectorOffset instancesOffset) { builder.AddOffset(12, instancesOffset.Value, 0); }
  public static VectorOffset CreateInstancesVector(FlatBufferBuilder builder, Offset<InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInstancesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Mesh> EndMesh(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Mesh>(o);
  }
};


}
