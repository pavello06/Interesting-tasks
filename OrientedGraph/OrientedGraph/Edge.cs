namespace Oriented_Graph
{
    internal class Edge<T>
    {
        public List<Vertex<T>> Vertices;

        public Edge()
        {
            Vertices = new List<Vertex<T>>();
        }
    }
}
