// by Wes Thompson
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_NodeCount
    {
        [TestMethod]
        public void GetNodeCount0()
        {
            var g = new CustomGraph();

            Assert.AreEqual(0, g.NodeCount());
        }

        [TestMethod]
        public void GetNodeCount10()
        {
            var g = new CustomGraph();

            for (int i = 0; i < 10; i++)
            {
                g.AddNode();
            }

            Assert.AreEqual(10, g.NodeCount());
        }
    }
}
