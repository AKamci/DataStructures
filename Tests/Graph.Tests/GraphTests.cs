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


        [Fact]
        public void Should_Example_Graph()
        {
            var graph = new Graph();
            var NodeF = new Node("f");
            var NodeG = new Node("g");
            var NodeA = new Node("a");
            var NodeB = new Node("b");
            var NodeC = new Node("c");
            var NodeD = new Node("d");
            var NodeE = new Node("e");
            var edgeFG = new Edge(NodeF, NodeG, 8);
            var edgeFE = new Edge(NodeF, NodeE, 15);
            var edgeFD = new Edge(NodeF, NodeD, 22);
            var edgeGA = new Edge(NodeG, NodeA, 10);
            var edgeGE = new Edge(NodeG, NodeE, 50);
            var edgeAB = new Edge(NodeA, NodeB, 6);
            var edgeBC = new Edge(NodeB, NodeC, 2);
            var edgeCD = new Edge(NodeC, NodeD, 30);
            var edgeED = new Edge(NodeE, NodeD, 10);
            graph.AddNode(NodeF);
            graph.AddNode(NodeG);
            graph.AddNode(NodeA);
            graph.AddNode(NodeB);
            graph.AddNode(NodeC);
            graph.AddNode(NodeD);
            graph.AddNode(NodeE);
            graph.AddEdge(edgeFG);
            graph.AddEdge(edgeFE);
            graph.AddEdge(edgeFD);
            graph.AddEdge(edgeGA);
            graph.AddEdge(edgeGE);
            graph.AddEdge(edgeAB);
            graph.AddEdge(edgeBC);
            graph.AddEdge(edgeCD);
            graph.AddEdge(edgeED);          
            var edgeNumber = graph.NumberOfEdges;
            var nodeNumber = graph.NumberOfNodes;
         
            Assert.Equal(9,edgeNumber);
            Assert.Equal(7,nodeNumber);
        }
    }
}