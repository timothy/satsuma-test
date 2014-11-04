// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_ArcLookup_IsEdge
    {
        [TestMethod]
        public void IsEdgeUndirected01()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Undirected);
            
            Assert.IsTrue(g.IsEdge(a1));
        }

        [TestMethod]
        public void IsEdgeUndirected10()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            for (int i = 0; i < 10; i++)
            {
                g.AddArc(n1, n2, Directedness.Undirected);
            }

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsTrue(g.IsEdge(a));
            }
        }

        [TestMethod]
        public void IsEdgeDirected01()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var a1 = g.AddArc(n1, n2, Directedness.Directed);

            Assert.IsFalse(g.IsEdge(a1));
        }

        [TestMethod]
        public void IsEdgeDirected10()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            for (int i = 0; i < 10; i++)
            {
                g.AddArc(n1, n2, Directedness.Directed);
            }

            foreach (Arc a in g.Arcs(ArcFilter.All))
            {
                Assert.IsFalse(g.IsEdge(a));
            }
        }
    }
}
