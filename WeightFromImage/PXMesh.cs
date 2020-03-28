using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PEPlugin.Pmx
{
    class PXSide : IEquatable<PXSide>, IEqualityComparer<PXSide>
    {
        public IPXVertex[] VertexPair { get; private set; }

        public PXSide()
        {
            VertexPair = new IPXVertex[2];
        }

        public PXSide(IPXVertex vertex1, IPXVertex vertex2)
        {
            VertexPair = new IPXVertex[2] { vertex1, vertex2 };
        }

        public static List<PXSide> FromFace(IPXFace face)
        {
            var list = new List<PXSide>();
            list.Add(new PXSide(face.Vertex1, face.Vertex2));
            list.Add(new PXSide(face.Vertex2, face.Vertex3));
            list.Add(new PXSide(face.Vertex3, face.Vertex1));
            return list;
        }

        public bool Equals(PXSide other)
        {
            if (VertexPair[0] == other.VertexPair[0])
                return VertexPair[1] == other.VertexPair[1];
            if (VertexPair[0] == other.VertexPair[1])
                return VertexPair[1] == other.VertexPair[0];
            return false;
        }

        public bool Equals(PXSide x, PXSide y) => x.Equals(y);

        public int GetHashCode(PXSide obj) => (VertexPair[0].GetHashCode() / 2) + (VertexPair[1].GetHashCode() / 2);
    }
    class PXMesh
    {
        private List<PXSide> _Sides { get; set; }
        public ReadOnlyCollection<PXSide> Sides { get => _Sides.AsReadOnly(); }
        private List<IPXVertex> _Vertices { get; set; }
        public ReadOnlyCollection<IPXVertex> Vertices { get => _Vertices.AsReadOnly(); }

        public PXMesh()
        {
            _Sides = new List<PXSide>();
            _Vertices = new List<IPXVertex>();
        }

        public PXMesh(IPXMaterial material)
        {
            _Sides = new List<PXSide>();
            _Vertices = new List<IPXVertex>();

            foreach (var f in material.Faces)
            {
                AddRange(PXSide.FromFace(f));
            }
        }

        public void Add(PXSide side)
        {
            if (!_Sides.Contains(side))
            {
                _Sides.Add(side);
                if (!_Vertices.Contains(side.VertexPair[0]))
                    _Vertices.Add(side.VertexPair[0]);
                if (!_Vertices.Contains(side.VertexPair[1]))
                    _Vertices.Add(side.VertexPair[1]);
            }
        }

        public void AddRange(IEnumerable<PXSide> sides)
        {
            foreach (var item in sides)
            {
                Add(item);
            }
        }
    }
}
