// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_ArcLookup_UV
    {
        [TestMethod]
        public void UndirectedU01()
        {
            var g = new CustomGraph();
            var n1 = new Node(0);
            var n2 = new Node(1);
            var a1 = g.AddArc(n1, n2, Directedness.Undirected);

            Assert.AreEqual(n1, g.U(a1));
        }
    }
}
