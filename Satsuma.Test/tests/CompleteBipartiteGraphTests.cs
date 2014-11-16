using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class CompleteBipartiteGraphTests
    {
        [TestMethod]
        public void RedNodeCountU()
        {
            var a = new CompleteBipartiteGraph(5,5,Directedness.Undirected);

            Assert.AreEqual(5, a.RedNodeCount);
        }
        [TestMethod]
        public void BlueNodeCountU()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Undirected);

            Assert.AreEqual(5, a.BlueNodeCount);
        }

        [TestMethod]
        public void RedNodeCountD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            Assert.AreEqual(5, a.RedNodeCount);
        }
        [TestMethod]
        public void BlueNodeCountD()
        {
            var a = new CompleteBipartiteGraph(5, 5, Directedness.Directed);

            Assert.AreEqual(5, a.BlueNodeCount);
        }
    }
}
