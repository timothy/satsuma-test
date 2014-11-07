// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_DeletionTests
    {
        [TestMethod]
        public void DeleteNodeInDirectedArcU()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            g.AddArc(n1, n2, Directedness.Directed);

            g.DeleteNode(n1);

            Assert.AreEqual(0, g.ArcCount());

            // Quite possibly a bug if I did the test correctly.
            // I don't believe there should be an arc anymore if one of the nodes is deleted, yes?
        }

        [TestMethod]
        public void DeleteNodeInUndirectedArcU()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            g.AddArc(n1, n2, Directedness.Undirected);

            g.DeleteNode(n1);

            Assert.AreEqual(0, g.ArcCount());

            // Quite possibly a bug if I did the test correctly.
            // I don't believe there should be an arc anymore if one of the nodes is deleted, yes?
        }

        [TestMethod]
        public void DeleteNodeInDirectedArcV()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            g.AddArc(n1, n2, Directedness.Directed);

            g.DeleteNode(n2);

            Assert.AreEqual(0, g.ArcCount());

            // Quite possibly a bug if I did the test correctly.
            // I don't believe there should be an arc anymore if one of the nodes is deleted, yes?
        }

        [TestMethod]
        public void DeleteNodeInUndirectedArcV()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            g.AddArc(n1, n2, Directedness.Undirected);

            g.DeleteNode(n2);

            Assert.AreEqual(0, g.ArcCount());

            // Quite possibly a bug if I did the test correctly.
            // I don't believe there should be an arc anymore if one of the nodes is deleted, yes?
        }

        [TestMethod]
        public void DeleteUnusedNodeDirected()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(3);
            g.AddArc(n1, n3, Directedness.Directed);

            g.DeleteNode(n2);

            Assert.AreEqual(1, g.ArcCount());
        }

        [TestMethod]
        public void DeleteUnusedNodeUndirected()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(3);
            g.AddArc(n1, n3, Directedness.Undirected);

            g.DeleteNode(n2);

            Assert.AreEqual(1, g.ArcCount());
        }
    }
}
