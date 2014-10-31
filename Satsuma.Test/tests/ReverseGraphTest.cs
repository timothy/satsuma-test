//By Ty Harding


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class ReverseGraphTest
    {
        [TestMethod]
        public void TestCreateReverse()
        {
            var c = new CompleteGraph(5,Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 5); //test that a graph with 5 nodes is created
        }

        [TestMethod]
        public void TestZeroNumNodes()
        {
            var c = new CompleteGraph(0, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 0); //test that a graph with 0 nodes is created
        }

        [TestMethod]
        public void TestNegativeNumNodes()
        {
            var c = new CompleteGraph(-1, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), -1); //what happens when a graph with negative nodes is created?
        }

        [TestMethod]
        public void TestHighNumberOfNodes()
        {
            var c = new CompleteGraph(1000, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 1000);
        }


    }
}
