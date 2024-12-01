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

        
        
    }
}
