namespace Graph;
public class Graph
{
    private List<Node> nodes;
    private List<Edge> edges;

    public Graph()
    {
        nodes = new List<Node>();
        edges = new List<Edge>();
    }

    public void AddNode(Node node)
    {
        nodes.Add(node);
    }

    public void AddEdge(Edge edge)
    {
        edges.Add(edge);
    }

    public int NumberOfNodes => nodes.Count;

    public int NumberOfEdges => edges.Count;
}
