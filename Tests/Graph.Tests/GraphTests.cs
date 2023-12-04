namespace Graph.Tests
{
    public class GraphTests
    {
        [Fact]
        public void Should_Create_Graph_Instance()
        {
            var graph = new Graph();

            Assert.NotNull(graph);
        }

        [Fact]
        public void Should_Create_Node_Instances()
        {
            var nodeA = new Node("A");
            var nodeB = new Node("B");

            Assert.NotNull(nodeA);
            Assert.NotNull(nodeB);
        }

        [Fact]
        public void Should_Add_Nodes_To_Graph()
        {
            var graph = new Graph();

            var nodeA = new Node("A");
            var nodeB = new Node("B");

            graph.AddNode(nodeA);
            graph.AddNode(nodeB);

            Assert.Equal(2, graph.NumberOfNodes);
            Assert.Equal(0, graph.NumberOfEdges);
        }

        [Fact]
        public void Should_Add_Nodes_And_One_Edge_To_Graph()
        {
            var graph = new Graph();

            var nodeA = new Node("A");
            var nodeB = new Node("B");

            var edge = new Edge(nodeA, nodeB, 10);

            graph.AddEdge(edge);

            Assert.NotNull(edge);
            Assert.Equal(nodeA, edge.From);
            Assert.Equal(nodeB, edge.To);
            Assert.Equal(1, graph.NumberOfEdges);
        }
    }
}