// Copyright 2016 InWorldz Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using OpenMetaverse;
using OpenMetaverse.Rendering;
using OpenSim.Framework;
using Murmurhash264A;
using OpenSim.Region.Framework.Scenes;

namespace InWorldz.PrimExporter.ExpLib
{
    public sealed class ObjectHasher
    {
        /// <summary>
        /// Calculate a hash for all primitives in a group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public ulong GetGroupHash(SceneObjectGroup group)
        {
            ulong hash = 5381;
            var parts = group.GetParts().OrderBy(p => p.LinkNum);
            foreach (var part in parts)
            {
                hash = Murmur2.Hash(GetPrimHash(part.Shape), hash);
            }

            return hash;
        }

        /// <summary>
        /// Calculate a hash that takes both the prim shape and materials into account
        /// </summary>
        public ulong GetPrimHash(ulong materialHash, ulong shapeHash)
        {
            return Murmur2.Hash(materialHash, shapeHash);
        }

        /// <summary>
        /// Calculate a hash that takes both the prim shape and materials into account
        /// </summary>
        public ulong GetPrimHash(PrimitiveBaseShape shape)
        {
            Primitive prim = shape.ToOmvPrimitive(Vector3.Zero, Quaternion.Identity);
            return GetPrimHash(prim, shape);
        }

        /// <summary>
        /// Calculate a hash that takes both the prim shape and materials into account
        /// </summary>
        public ulong GetPrimHash(Primitive prim, PrimitiveBaseShape shape)
        {
            return GetPrimHash(GetMeshMaterialHash(prim), GetMeshShapeHash(shape));
        }

        /// <summary>
        /// Calculate a hash value over fields that can affect the underlying physics shape.
        /// Things like RenderMaterials and TextureEntry data are not included.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="lod"></param>
        /// <returns>ulong - a calculated hash value</returns>
        public ulong GetMeshShapeHash(PrimitiveBaseShape shape)
        {
            const DetailLevel lod = DetailLevel.Highest;
            ulong hash = 5381;

            hash = Murmur2.Hash(shape.PathCurve, hash);
            hash = Murmur2.Hash((byte)((byte)shape.HollowShape | (byte)shape.ProfileShape), hash);
            hash = Murmur2.Hash(shape.PathBegin, hash);
            hash = Murmur2.Hash(shape.PathEnd, hash);
            hash = Murmur2.Hash(shape.PathScaleX, hash);
            hash = Murmur2.Hash(shape.PathScaleY, hash);
            hash = Murmur2.Hash(shape.PathShearX, hash);
            hash = Murmur2.Hash(shape.PathShearY, hash);
            hash = Murmur2.Hash((byte)shape.PathTwist, hash);
            hash = Murmur2.Hash((byte)shape.PathTwistBegin, hash);
            hash = Murmur2.Hash((byte)shape.PathRadiusOffset, hash);
            hash = Murmur2.Hash((byte)shape.PathTaperX, hash);
            hash = Murmur2.Hash((byte)shape.PathTaperY, hash);
            hash = Murmur2.Hash(shape.PathRevolutions, hash);
            hash = Murmur2.Hash((byte)shape.PathSkew, hash);
            hash = Murmur2.Hash(shape.ProfileBegin, hash);
            hash = Murmur2.Hash(shape.ProfileEnd, hash);
            hash = Murmur2.Hash(shape.ProfileHollow, hash);

            // Include LOD in hash, accounting for endianness
            byte[] lodBytes = new byte[4];
            Buffer.BlockCopy(BitConverter.GetBytes((int)lod), 0, lodBytes, 0, 4);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(lodBytes, 0, 4);
            }

            hash = Murmur2.Hash(shape.ProfileHollow, hash);

            // include sculpt UUID
            if (shape.SculptEntry)
            {
                var sculptUuidBytes = shape.SculptTexture.GetBytes();
                hash = Murmur2.Hash(sculptUuidBytes, hash);
                hash = Murmur2.Hash(shape.SculptType, hash);
            }

            return hash;
        }

        /// <summary>
        /// Returns a hash value calculated from face parameters that would affect
        /// the appearance of the mesh faces but not their shape
        /// </summary>
        /// <returns></returns>
        public ulong GetMeshMaterialHash(Primitive prim)
        {
            ulong hash = 5381;

            int numFaces = prim.Textures.FaceTextures.Count(face => face != null);
            for (int i = 0; i < numFaces; i++)
            {
                Primitive.TextureEntryFace teFace = prim.Textures.GetFace((uint)i);
                hash = GetMaterialFaceHash(hash, teFace);
            }

            return hash;
        }

        public ulong GetMaterialFaceHash(ulong hash, Primitive.TextureEntryFace teFace)
        {
            hash = Murmur2.Hash((ushort) teFace.Bump, hash);
            hash = Murmur2.Hash((byte) (teFace.Fullbright ? 1 : 0), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.Glow), hash);
            hash = Murmur2.Hash((byte) (teFace.MediaFlags ? 1 : 0), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.OffsetU), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.OffsetV), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.RepeatU), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.RepeatV), hash);
            hash = Murmur2.Hash(BitConverter.GetBytes(teFace.Rotation), hash);
            hash = Murmur2.Hash(teFace.RGBA.GetBytes(), hash);
            hash = Murmur2.Hash((byte) teFace.Shiny, hash);
            hash = Murmur2.Hash((byte) teFace.TexMapType, hash);
            hash = Murmur2.Hash(teFace.TextureID.GetBytes(), hash);
            return hash;
        }

        public ulong GetMaterialFaceHash(Primitive.TextureEntryFace teFace)
        {
            ulong hash = 5381;
            return GetMaterialFaceHash(hash, teFace);
        }
    }
}
