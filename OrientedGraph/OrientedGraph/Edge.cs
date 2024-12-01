namespace Oriented_Graph
{
    internal class Edge<T>
    {
        public List<Vertex<T>> Verticies;

        public Edge()
        {
            Verticies = new List<Vertex<T>>();
        }
    }
}
