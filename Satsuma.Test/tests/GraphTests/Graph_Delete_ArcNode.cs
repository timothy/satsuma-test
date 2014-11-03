// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_Delete_ArcNode
    {
        [TestMethod]
        public void DeleteArcDirected()
        {
            var g = new CustomGraph();
            Node n1 = new Node(5);
            Node n2 = new Node(12);
            Arc a1 = g.AddArc(n1, n2, Directedness.Directed);
            
            Assert.IsTrue(g.DeleteArc(a1));
        }

        [TestMethod]
        public void DeleteArcUndirected()
        {
            var g = new CustomGraph();
            Node n1 = new Node(5);
            Node n2 = new Node(12);
            Arc a1 = g.AddArc(n1, n2, Directedness.Undirected);

            Assert.IsTrue(g.DeleteArc(a1));
        }

        [TestMethod]
        public void DeleteNode()
        {
            var g = new CustomGraph();
            Node n1 = g.AddNode();

            Assert.IsTrue(g.DeleteNode(n1));
        }
    }
}
