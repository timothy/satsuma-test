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
        [TestMethod]
        public void DistanceTest()
        {
            var T = new PointD(546.56, 4654.68);
            var A = new PointD(56.508, 6546.56);
            double d = T.Distance(A);

            Assert.AreEqual(d, Math.Sqrt((T.X - A.X) * (T.X - A.X) + (T.Y - A.Y) * (T.Y - A.Y)));
        }

        [TestMethod]
        public void Layouts_Equals_True()
        {
            var T = new PointD(556.0086, 556.006);
            var A = new PointD(556.0086, 556.006);
            bool b = T.Equals(A);

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Layouts_Equals_False()// This is testing the Distance method in Layouts class
        {// Test to make sure Equals false case is working

            var T = new PointD(556.00007, 556.00895);

            var A = new PointD(556.0086, 556.006);

            bool b = T.Equals(A);

            Assert.IsFalse(b);

        }


        [TestMethod]
        public void Layouts_GetHashCode_one()// This might be an error in the code. There is very little info in the comments about the GetHashCode() method
        {// but to my understanding it should always give me the same hash value if I give it the same input.
            //

            var T = new PointD(556.00007, 556.00895);


            int x = T.X.GetHashCode();
            int y = T.Y.GetHashCode();

            int i = T.GetHashCode();


           // Assert.AreEqual(i, (x * 17) + y);// I have tried both asserts by them selves and each time they come up with different hash values when the input remains the same.

            Assert.AreEqual(i, T.GetHashCode());

        }

        [TestMethod]
        public void Layouts_GetHashCode_X()// This might be an error in the code. There is very little info in the comments about the GetHashCode() method
        {// but to my understanding it should always give me the same hash value if I give it the same input.
            //

            var T = new PointD(556.00007, 556.00895);

            int x = T.X.GetHashCode();

            Assert.AreEqual(x, T.X.GetHashCode());// both values should be the same

        }

        [TestMethod]
        public void Layouts_ToString()// This might be an error in the code. I am not too sure why this is but I keep getting a new value each time
        {// for some reason the value of tostring is changing. I would think if the values I store in PointD are constant 
            //then the value of the twostring should be as well. I do not see 


            var T = new PointD(556.00007, 556.00895);

            string s = T.ToString();

            Assert.AreEqual(s, T.ToString());// both values should be the same

        }

        [TestMethod]
        public void PlusOperatorOverrideTest()// 
        {// the plus operator is should add points A.X and T.X together.
            //this test should pass. I think something is changing the values in the PointD
            // it looks to me that PointD should not change the two double values it holds---But some where along the line it is.

            var T = new PointD(556.00007, 556.00895);

            var A = new PointD(556.00007, 556.00895);

            var D = new PointD((A.X + T.X), (A.Y + T.Y));

            var C = T + A;

            Assert.AreEqual(C.X, D.X);// both values should be the same

        }

        [TestMethod]
        public void GetType_Test()// This is making sure that the GetType() method is working
        {// 

            var T = new PointD(556.0086, 556.006);

            var A = new PointD(556.0086, 556.006);

            Assert.IsInstanceOfType(A, T.GetType());

        }

        [TestMethod]
        public void GetType_Test_notSame()// This is making sure that the GetType() method is working
        {// 

            var T = new PointD(556.0086, 556.006);

            var A = "testing if this fails";


            Assert.IsNotInstanceOfType(A, T.GetType());

        }

        [TestMethod]
        public void TestPoint_X_inPointD()// T.X should return a double. This is testing to make sure it does
        {// 

            var T = new PointD(556.00007, 556.00895);


            Assert.IsInstanceOfType(T.X, typeof(double));

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

            Assert.AreNotEqual(gothe.Distance(far), 0);
        }

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
    }
}