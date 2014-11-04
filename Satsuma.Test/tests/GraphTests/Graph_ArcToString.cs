// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_ArcToString
    {
        [TestMethod]
        public void ValidDirectedArc()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Directed);

            Assert.AreEqual("#1--->#2", g.ArcToString(a1));
        }

        [TestMethod]
        public void InvalidDirectedArc()
        {
            var g = new CustomGraph();
            var g2 = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g2.AddArc(n1, n2, Directedness.Directed);

            Assert.AreEqual("#1--->#2", g.ArcToString(a1));

            // Supposed to fail
        }

        [TestMethod]
        public void ValidUndirectedArc()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Undirected);

            Assert.AreEqual("#1<-->#2", g.ArcToString(a1));
        }

        [TestMethod]
        public void InvalidUndirectedArc()
        {
            var g = new CustomGraph();
            var g2 = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g2.AddArc(n1, n2, Directedness.Directed);

            Assert.AreEqual("#1<-->#2", g.ArcToString(a1));

            // Supposed to fail
        }

        [TestMethod]
        public void DeletedNodeDirectedU()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Directed);
            g.DeleteNode(n1);

            Assert.AreEqual("#1--->#2", g.ArcToString(a1));

            // Not sure if bug
        }

        [TestMethod]
        public void DeletedNodeDirectedV()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Directed);
            g.DeleteNode(n2);

            Assert.AreEqual("#1--->#2", g.ArcToString(a1));

            // Not sure if bug
        }

        [TestMethod]
        public void DeletedNodeUndirectedU()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Undirected);
            g.DeleteNode(n1);

            Assert.AreEqual("#1<-->#2", g.ArcToString(a1));

            // Not sure if bug
        }

        [TestMethod]
        public void DeletedNodeUndirectedV()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Undirected);
            g.DeleteNode(n2);

            Assert.AreEqual("#1<-->#2", g.ArcToString(a1));

            // Not sure if bug
        }
    }
}
