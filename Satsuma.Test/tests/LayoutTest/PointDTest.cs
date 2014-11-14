using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Satsuma;
using Satsuma.Drawing;
using System.Globalization;

namespace Satsuma.Test.tests
{
    [TestClass]
    public class LayoutTest
    {
        //This is checking the distance based on the formala used
        [TestMethod]
        public void DistanceTest()
        {
            var T = new PointD(546.56, 4654.68);
            var A = new PointD(56.508, 6546.56);
            double d = T.Distance(A);

            Assert.AreEqual(d, Math.Sqrt((T.X - A.X) * (T.X - A.X) + (T.Y - A.Y) * (T.Y - A.Y)));
        }
        //This is checks the equals operator
        [TestMethod]
        public void Layouts_Equals_True()
        {
            var T = new PointD(556.0086, 556.006);
            var A = new PointD(556.0086, 556.006);
            bool b = T.Equals(A);

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Layouts_Equals_False()
        {
            // Test to make sure Equals false case is working
            var T = new PointD(556.00007, 556.00895);

            var A = new PointD(556.0086, 556.006);

            bool b = T.Equals(A);

            Assert.IsFalse(b);

        }
        [TestMethod]
        public void Layouts_GetHashCode_one()
        {
            var T = new PointD(556.00007, 556.00895);

            int x = T.X.GetHashCode();
            int y = T.Y.GetHashCode();

            int i = T.GetHashCode();

            Assert.AreEqual(i, T.GetHashCode());
        }

        [TestMethod]
        public void Layouts_GetHashCode_X()
        {
            var T = new PointD(556.00007, 556.00895);

            int x = T.X.GetHashCode();

            Assert.AreEqual(x, T.X.GetHashCode());

        }
        [TestMethod]
        public void Layouts_ToString()
        {
            var T = new PointD(556.00007, 556.00895);

            string s = T.ToString();

            Assert.AreEqual(s, T.ToString());
        }
        [TestMethod]
        public void PlusOperatorOverrideTest()
        {
            var T = new PointD(556.00007, 556.00895);

            var A = new PointD(556.00007, 556.00895);

            var D = new PointD((A.X + T.X), (A.Y + T.Y));

            var C = T + A;

            Assert.AreEqual(C.X, D.X);
        }
        // tests that go is 0 Distance from itself
        [TestMethod]
        public void ZeroDistance()
        {
            var go = new PointD(4.5, 45.67);

            Assert.IsTrue(go.Distance(go) == 0);
        }
        //tests max distance and confirms it is greater than 0
        [TestMethod]
        public void DistanceBoundery()
        {
            var far = new PointD(Double.MaxValue, Double.MaxValue);

            var gothe = new PointD(4.5, 45.67);

            Assert.AreNotEqual(gothe.Distance(far), 0);
        }
        // This tests the overloaded + operator
        [TestMethod]
        public void overloadedOperator1()
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(56.508, 6546.56);

            var c = new PointD(a.X + b.X, a.Y + b.Y);

            b += a;

            Assert.AreEqual(b, c);
        }
        // This tests the overloaded == operator true case
        [TestMethod]
        public void overloadedOperator2()
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.56, 4654.68);

            Assert.IsTrue(a == b);
        }
        // This tests the overloaded plus operator false case
        [TestMethod]
        public void overloadedOperator3()
        {
            var a = new PointD(546.56, 4654.68);

            var b = new PointD(564.54668, 4654.68);

            Assert.IsFalse(a == b);
        }
        // This tests the overloaded not equal != operator false case
        [TestMethod]
        public void overloadedOperator4()
        {

            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.56, 4654.68);

            Assert.IsFalse(a != b);
        }
        // This tests the overloaded not equal != operator true case
        [TestMethod]
        public void overloadedOperator5()
        {

            var a = new PointD(546.56, 4654.68);

            var b = new PointD(546.598786, 4654.68);

            Assert.IsTrue(a != b);
        }
    }
}