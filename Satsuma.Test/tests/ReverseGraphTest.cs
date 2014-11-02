//By Ty Harding
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class ReverseGraphTest
    {
        [TestMethod]
        public void CreateReverse()
        {
			var c = new CompleteGraph(1, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 1);
        }

        [TestMethod]
        public void ZeroNumNodes()
        {
			var c = new CompleteGraph(0, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), 0);
        }

        [TestMethod]
        public void HighNumberOfNodes()
        {
            const int numofnodes = 1000;

			var c = new CompleteGraph(numofnodes, Directedness.Directed);
            var g = new ReverseGraph(c);

            Assert.AreEqual(g.NodeCount(), numofnodes);
        }
    }
}
