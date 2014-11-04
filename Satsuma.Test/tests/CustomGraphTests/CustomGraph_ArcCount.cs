// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_ArcCount
    {
        [TestMethod]
        public void GetArcCount0()
        {
            var g = new CustomGraph();

            Assert.AreEqual(0, g.ArcCount());
        }

        [TestMethod]
        public void GetArcCount10Directed()
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

        [TestMethod]
        public void GetArcCount10Undirected()
        {
            var g = new CustomGraph();
            var n1 = new Node(1);
            var n2 = new Node(2);

            for (int i = 0; i < 10; i++)
            {
                g.AddArc(n1, n2, Directedness.Undirected);
            }

            Assert.AreEqual(10, g.ArcCount());
        }
    }
}
