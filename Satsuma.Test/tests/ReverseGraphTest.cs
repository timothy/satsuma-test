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
        public void ZeroNumNodes()
        {
			var c = new CompleteGraph(0, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 0);
        }

        [TestMethod]
        public void HighNumberOfNodes()
        {
            const int numofnodes = 1000;

			var c = new CompleteGraph(numofnodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), numofnodes);
        }

        [TestMethod]
        public void IsEdgeUndirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void IsEdgeDirected()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsFalse(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void UndirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void UndirectedAllHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void UndirectedEdge()
        {
            var c = new CompleteGraph(5, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void UndirectedEdgeHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Undirected);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void DirectedAll()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void DirectedAllHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void DirectedEdge()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(10, arcs);
        }

        [TestMethod]
        public void DirectedEdgeHighNumberOfNodes()
        {
            const int NumOfNodes = 10000;

            var c = new CompleteGraph(NumOfNodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(49995000, arcs);
        }

        [TestMethod]
        public void ArcsInvariant()
        {
            var c = new CompleteGraph(5, Directedness.Directed);
            var g = new ReverseGraph(c);

            int arcs = g.ArcCount(ArcFilter.All);
            int arcs2 = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(arcs2, arcs);
        }
    }
}
