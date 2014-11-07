using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class SubgraphTests
    {
        [TestMethod]
        public void CreateSubgraphOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Directed);
            var g = new Subgraph(c);

            Assert.AreEqual(g.NodeCount(), 1);
        }

        [TestMethod]
        public void CreateSubgraphZeroNode()
        {
            var c = new CompleteGraph(0, Directedness.Directed);
            var g = new Subgraph(c);

            Assert.AreEqual(g.NodeCount(), 0);
        }

        [TestMethod]
        public void CreateSubgraphHighNode()
        {
            var c = new CompleteGraph(1000, Directedness.Directed);
            var g = new Subgraph(c);

            Assert.AreEqual(g.NodeCount(), 1000);
        }

        [TestMethod]
        public void IsEdgeUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void IsEdgeDirected()
        {
            var c = new CompleteGraph(1, Directedness.Directed);
            var g = new Subgraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsFalse(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void UndirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void DirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void UndirectedAllOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Undirected);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void DirectedAllOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Directed);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void DirectedEdge()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void ArcsInvariant()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            int arcs = g.ArcCount(ArcFilter.All);
            int arcs2 = g.ArcCount(ArcFilter.All);


            Assert.AreEqual(arcs2, arcs);
        }

        [TestMethod]
        public void HasAllNodesUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            foreach (Node n in g.Nodes())
            {
                Assert.IsTrue(g.HasNode(n));
            }
        }

        [TestMethod]
        public void HasAllNodesDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            foreach (Node n in g.Nodes())
            {
                Assert.IsTrue(g.HasNode(n));
            }
        }

        [TestMethod]
        public void NotHaveNodeAboveDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            Node n = new Node(6);

            Assert.IsFalse(g.HasNode(n));
        }


        [TestMethod]
        public void NotHaveNodeAboveUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            Node n = new Node(6);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void NotHaveNodeBelowDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            Node n = new Node(-1);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void NotHaveNodeBelowUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            Node n = new Node(-1);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void HasAllArcsUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new Subgraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.HasArc(a));
            }

        }
        [TestMethod]
        public void HasAllArcsDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new Subgraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.HasArc(a));
            }
        }
    }
}
