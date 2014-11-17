using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Tests By Timothy
namespace Satsuma.Test.tests.CompleteBipatiteGraphTests
{
    [TestClass]
    public class CompletBipatiteGraph_ArcCount
    {
        #region arcs1
        [TestMethod]
        public void UndirectedAll()
        {
            var g = new CompleteBipartiteGraph(5,5, Directedness.Undirected);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(25, arcs);
        }

        [TestMethod]
        public void UndirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(25, arcs);
        }

        [TestMethod]
        public void DirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(25, arcs);
        }

        [TestMethod]
        public void DirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(ArcFilter.Edge);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void ArcsInvariant()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs1 = g.ArcCount(ArcFilter.All);
            int arcs2 = g.ArcCount(ArcFilter.All);

            Assert.AreEqual(arcs1, arcs2);
        }

        #endregion
        #region arcs2
        [TestMethod]
        public void FromNodeUndirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.All);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeUndirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Edge);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeUndirectedBackward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Backward);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeUndirectedForward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Forward);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeDirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.All);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeDirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Edge);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void FromNodeDirectedBackward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Backward);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void FromNodeDirectedForward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), ArcFilter.Forward);

            Assert.AreEqual(5, arcs);
        }

        [TestMethod]
        public void FromNodeArcsInvariant()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs1 = g.ArcCount(g.GetRedNode(0), ArcFilter.All);
            int arcs2 = g.ArcCount(g.GetRedNode(0), ArcFilter.All);

            Assert.AreEqual(arcs1, arcs2);
        }
        #endregion
        #region arcs3
        [TestMethod]
        public void NodeToNodeUndirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeUndirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetBlueNode(1), ArcFilter.Edge);

            Assert.AreEqual(1, arcs);
        }

        [TestMethod]
        public void NodeToNodeUndirectedBackward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetBlueNode(0), g.GetRedNode(1), ArcFilter.Backward);

            Assert.AreEqual(1, arcs);
        }

        [TestMethod]
        public void NodeToNodeUndirectedForward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.Forward);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeDirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.All);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeDirectedEdge()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.Edge);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeDirectedBackward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.Backward);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeDirectedForward()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            int arcs = g.ArcCount(g.GetBlueNode(0), g.GetBlueNode(1), ArcFilter.Forward);

            Assert.AreEqual(0, arcs);
        }

        [TestMethod]
        public void NodeToNodeArcsInvariant()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            int arcs1 = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.All);
            int arcs2 = g.ArcCount(g.GetRedNode(0), g.GetRedNode(1), ArcFilter.All);

            Assert.AreEqual(arcs1, arcs2);
        }
        #endregion
    }
}
