using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Graph
{
    internal class OrientedGraph<T> where T : IComparable<T>
    {
        public List<Vertex<T>> Verticies;

        public OrientedGraph()
        {
            Verticies = new List<Vertex<T>>();
        }

        public void AddVertex(T value)
        {
            if (!ContainsVertex(value))
            {
                var vertex = new Vertex<T>(value);
                Verticies.Add(vertex);
            }
        }

        private bool ContainsVertex(T value)
        {
            foreach (var vertex in Verticies) 
            {
                if (vertex.Value.CompareTo(value) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveVertex(T value)
        {
            for (int i = 0; i < Verticies.Count; i++)
            {
                if (Verticies[i].Value.CompareTo(value) == 0)
                {
                    Verticies.RemoveAt(i);
                    return;
                }
            }
        }
        
    }
}
