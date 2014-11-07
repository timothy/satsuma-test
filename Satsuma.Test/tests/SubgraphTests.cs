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
    }
}
