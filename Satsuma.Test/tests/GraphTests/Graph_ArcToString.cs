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
            var a1 = new Arc(1);

            Assert.AreNotEqual("#1--->#2", g.ArcToString(a1));
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
    }
}
