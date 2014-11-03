using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Graph_Arcs
    {
        [TestMethod]
        public void ArcToStringOverride()
        {
            var a1 = new Arc(10);

            Assert.AreEqual("|10", a1.ToString());
        }

        [TestMethod]
        public void FalseArcID()
        {
            var a1 = new Arc(1);
            var a2 = new Arc(20);

            Assert.IsFalse(a1.Equals(a2));
        }

        [TestMethod]
        public void TrueArcID()
        {
            var a1 = new Arc(3534);
            var a2 = new Arc(3534);

            Assert.IsTrue(a1.Equals(a2));
        }

        [TestMethod]
        public void NegativeArcID()
        {
            var a1 = new Arc(-234);

            Assert.AreEqual(-234, a1.Id);
        }

        [TestMethod]
        public void NegativeArcIDToString()
        {
            var a1 = new Arc(-353);

            Assert.AreEqual("|-353", a1.ToString());
        }

        [TestMethod]
        public void VeryLongArcID()
        {
            var a1 = new Arc(9223372036854775807);

            Assert.AreEqual(9223372036854775807, a1.Id);

            //That is Int64.MaxValue
        }

        [TestMethod]
        public void ArcID_0()
        {
            var a1 = new Arc(0);

            Assert.AreEqual(0, a1.Id);
        }
    }
}
