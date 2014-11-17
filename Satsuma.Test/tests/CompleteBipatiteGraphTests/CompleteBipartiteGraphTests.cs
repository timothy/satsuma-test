using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Tests By Timothy
namespace Satsuma.Test.tests
{
    [TestClass]
    public class CompleteBipartiteGraphTests
    {
        //The following tests are testing within bounds of methods
        [TestMethod]
        public void RedNodeCountU()
        {
            var a = new CompleteBipartiteGraph(5,5,Directedness.Undirected);

            Assert.AreEqual(5, a.RedNodeCount);
        }
        [TestMethod]
        public void BlueNodeCountU()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            Assert.AreEqual(5, a.BlueNodeCount);
        }

        [TestMethod]
        public void RedNodeCountD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            Assert.AreEqual(5, a.RedNodeCount);
        }
        [TestMethod]
        public void BlueNodeCountD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            Assert.AreEqual(5, a.BlueNodeCount);
        }
        [TestMethod]
        public void GetBlueNodeU()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            var b = new Node(6);

            Assert.AreEqual(b, a.GetBlueNode(0));
        }
        [TestMethod]
        public void GetRedNodeU()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            var b = new Node(1);

            Assert.AreEqual(b, a.GetRedNode(0));
        }
        [TestMethod]
        public void GetBlueNodeD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            var b = new Node(6);

            Assert.AreEqual(b, a.GetBlueNode(0));
        }
        [TestMethod]
        public void GetRedNodeD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            var b = new Node(1);

            Assert.AreEqual(b, a.GetRedNode(0));
        }
        [TestMethod]
        public void IsRedT()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            var b = new Node(0);

            Assert.AreEqual(true, a.IsRed(b));
        }
        [TestMethod]
        public void IsRedF()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            var b = new Node(6);

            Assert.AreEqual(false, a.IsRed(b));
        }
        [TestMethod]
        public void GetArcInvalide()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            var b = new Node(6);
            var c = new Node(6);

            Assert.AreEqual(Arc.Invalid, a.GetArc(b, c));
        }
        //Test case with max values for input should throw out of range exeption
        //The following tests are testing outside the bounds

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompleteBipartiteGraphMaxOutOfRang()
        {
            var a = new CompleteBipartiteGraph(Int32.MaxValue, Int32.MaxValue, Directedness.Undirected);

            Assert.AreEqual(Int32.MaxValue, a.RedNodeCount);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompleteBipartiteGraphMinOutOfRang()
        {
            var a = new CompleteBipartiteGraph(Int32.MinValue, Int32.MinValue, Directedness.Undirected);

            Assert.AreEqual(Int32.MinValue, a.RedNodeCount);
        }
        [TestMethod]
        public void NodeToNodeUndirectedForward()
        {
            var g = new CompleteBipartiteGraph(5,5, Directedness.Undirected);

            int arcs = g.ArcCount(g.GetBlueNode(0), g.GetRedNode(1), ArcFilter.Forward);

            Assert.AreEqual(1, arcs);
        }
        [TestMethod]
        public void UndirectedAll()
        {
            var g = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

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
    }
}
