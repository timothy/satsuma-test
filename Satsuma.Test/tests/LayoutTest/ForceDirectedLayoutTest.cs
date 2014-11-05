using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Satsuma;
using Satsuma.Drawing;
using System.Globalization;

namespace Satsuma.Test.tests.LayoutTests
{
    [TestClass]
    public class HW7
    {
        
        [TestMethod]
        public void LayoutNodeTest1()// This tests the layout of ForceDirectedLayout
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);
            layout.Run();

            foreach (var node in g.Nodes())
                Assert.IsNotNull(node);
        }
        [TestMethod]
        public void LayoutNodeTest2()// this tests that the NodePositions are giving positions
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);
            layout.Run();

            foreach (var node in g.Nodes())
                Assert.IsNotNull(layout.NodePositions[node]);
        }

        [TestMethod]
        public void CorrectTemp()//Checks the annealing temps are grater than min temp
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);

            Assert.IsTrue(layout.Temperature > ForceDirectedLayout.DefaultMinimumTemperature);
        }

        
    }
}
