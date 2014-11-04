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
        public void overloadedOperator1()// This tests the overloaded + operator
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(56.508, 6546.56);

            var c = new PointD(a.X + b.X, a.Y + b.Y);

            b += a;

            Assert.AreEqual(b, c);
           
        }

        [TestMethod]
        public void overloadedOperator2()// This tests the overloaded == operator true case
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.56, 4654.68);

            Assert.IsTrue(a == b);
        }

        [TestMethod]
        public void overloadedOperator3()// This tests the overloaded plus operator false case
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(564.54668, 4654.68);

            Assert.IsFalse(a == b);
        }
        [TestMethod]
        public void overloadedOperator4()// This tests the overloaded not equal != operator false case
        {
           
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.56, 4654.68);

            Assert.IsFalse(a != b);
        }
        [TestMethod]
        public void overloadedOperator5()// This tests the overloaded not equal != operator true case
        {
           
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.598786, 4654.68);

            Assert.IsTrue(a != b);
        }
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

        [TestMethod]
        public void ZeroDistance()// tests that go is 0 Distance from itself
        {
              var go = new PointD(4.5, 45.67);

            Assert.IsTrue(go.Distance(go) == 0);
        }

        [TestMethod]
        public void DistanceBoundery()//tests max distance and confirms it is greater than 0
        {
            var far = new PointD(Double.MaxValue, Double.MaxValue);

            var gothe = new PointD(4.5, 45.67);

            Assert.AreNotEqual(gothe.Distance(far),0);
        }
    }
}
