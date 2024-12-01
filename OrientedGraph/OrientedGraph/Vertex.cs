namespace Oriented_Graph
{
    internal class Vertex<T>
    {
        public T Value;
        public Edge<T> Edges;

        public Vertex(T value)
        {
            Value = value;
            Edges = new Edge<T>();
        }
    }
}
