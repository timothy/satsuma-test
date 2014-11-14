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
        // This tests the layout of ForceDirectedLayout
        [TestMethod]
        public void LayoutNodeTest1()
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);
            layout.Run();

            foreach (var node in g.Nodes())
                Assert.IsNotNull(node);
        }
        // this tests that the NodePositions are giving positions
        [TestMethod]
        public void LayoutNodeTest2()
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);
            layout.Run();

            foreach (var node in g.Nodes())
                Assert.IsNotNull(layout.NodePositions[node]);
        }
        //Checks the annealing temps are grater than min temp
        [TestMethod]
        public void CorrectTemp()
        {
            var g = new CompleteGraph(7, Directedness.Directed);
            var layout = new ForceDirectedLayout(g);

            Assert.IsTrue(layout.Temperature > ForceDirectedLayout.DefaultMinimumTemperature);
        }

        
    }
}
