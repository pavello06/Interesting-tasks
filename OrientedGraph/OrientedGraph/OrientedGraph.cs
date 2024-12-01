namespace Oriented_Graph
{
    internal class OrientedGraph<T> where T : IComparable<T>
    {
        public List<Vertex<T>> Verticies;

        public OrientedGraph()
        {
            Verticies = new List<Vertex<T>>();
        }

        public Vertex<T>? GetVertex(T value)
        {
            foreach (var vertex in Verticies)
            {
                if (vertex.Value.CompareTo(value) == 0)
                {
                    return vertex;
                }
            }
            return null;
        }

        public void AddVertex(T value)
        {
            if (GetVertex(value) == null)
            {
                var vertex = new Vertex<T>(value);
                Verticies.Add(vertex);
            }
        }

        public void RemoveVertex(T value)
        {
            var vertex1 = GetVertex(value);
            foreach (var vertex2 in Verticies)
            {
                RemoveEdge(vertex2.Value, vertex1.Value);
            }
            Verticies.Remove(vertex1);
        }

        public void AddEdge(T value1, T value2)
        {
            AddVertex(value1);
            AddVertex(value2);

            var vertex1 = GetVertex(value1);
            var vertex2 = GetVertex(value2);
            if (!vertex1.Edges.Verticies.Contains(vertex2))
            {
                vertex1.Edges.Verticies.Add(vertex2);
            }
        }

        public void RemoveEdge(T value1, T value2)
        {
            var vertex1 = GetVertex(value1);
            var vertex2 = GetVertex(value2);
            vertex1.Edges.Verticies.Remove(vertex2);
        }
    }
}
