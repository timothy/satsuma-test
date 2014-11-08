//By Ty Harding
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class ReverseGraphTest
    {
        [TestMethod]
        public void CreateReverse()
        {
			var c = new CompleteGraph(1, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 1);
        }

        [TestMethod]
        public void ReverseGraphZeroNumNodes()
        {
			var c = new CompleteGraph(0, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 0);
        }

        [TestMethod]
        public void ReverseGraphHighNumberOfNodes()
        {
            const int numofnodes = 1000;

			var c = new CompleteGraph(numofnodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), numofnodes);
        }

        [TestMethod]
        public void ReverseGraphIsEdgeUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void ReverseGraphIsEdgeUndirectedOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void ReverseGraphIsEdgeDirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsFalse(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void ReverseGraphIsEdgeDirectedOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsFalse(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void ReverseGraphUndirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void ReverseGraphUndirectedAllOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void ReverseGraphUndirectedAllHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void ReverseGraphUndirectedEdge()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void ReverseGraphUndirectedEdgeOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void ReverseGraphUndirectedEdgeHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedAllOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedAllHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedEdge()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedEdgeOneNode()
        {
            var c = new CompleteGraph(1, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void ReverseGraphDirectedEdgeHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void ReverseGraphArcsInvariant()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);
            int arcs2 = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(arcs2, arcs);
        }

        [TestMethod]
        public void HasAllNodesDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            foreach (Node n in g.Nodes())
            {
                Assert.IsTrue(g.HasNode(n));
            }
        }

        [TestMethod]
        public void HasAllNodesUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Node n in g.Nodes())
            {
                Assert.IsTrue(g.HasNode(n));
            }
        }

        [TestMethod]
        public void NotHaveNodeAboveDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            Node n = new Node(6);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void NotHaveNodeAboveUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            Node n = new Node(6);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void NotHaveNodeBelowDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            Node n = new Node(-1);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void NotHaveNodeBelowUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            Node n = new Node(-1);

            Assert.IsFalse(g.HasNode(n));
        }

        [TestMethod]
        public void HasAllArcsUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.HasArc(a));
            }
            
        }
        [TestMethod]
        public void HasAllArcsDirected()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.HasArc(a));
            }
        }


    }
}
