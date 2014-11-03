// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_Add_ArcNode
    {
        [TestMethod]
        public void Add1Node()
        {
            var g = new CustomGraph();
            g.AddNode();

            Assert.AreEqual(1, g.NodeCount());
        }

        [TestMethod]
        public void Add10Nodes()
        {
            var g = new CustomGraph();
            for (int i = 0; i < 10; i++)
            {
                g.AddNode();
            }

            Assert.AreEqual(10, g.NodeCount());
        }

        [TestMethod]
        public void Add1Arc()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            g.AddArc(n1, n2, Directedness.Directed);

            Assert.AreEqual(1, g.ArcCount());
        }

        [TestMethod]
        public void Add10Arcs()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            for (int i = 0; i < 10; i++)
            {
                g.AddArc(n1, n2, Directedness.Directed);
            }

            Assert.AreEqual(10, g.ArcCount());
        }
    }
}
