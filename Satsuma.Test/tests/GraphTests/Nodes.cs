using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.GraphTests
{
    [TestClass]
    public class Nodes
    {
        [TestMethod]
        public void FalseNodeID()
        {
            var n1 = new Node(27);
            var n2 = new Node(918);

            Assert.IsFalse(n1.Equals(n2));
        }

        [TestMethod]
        public void TrueNodeID()
        {
            var n1 = new Node(537);
            var n2 = new Node(537);

            Assert.IsTrue(n1.Equals(n2));
        }

        [TestMethod]
        public void NegativeID()
        {
            var n1 = new Node(-10);

            Assert.AreEqual(-10, n1.Id);
            // Not sure if there are supposed to be negative IDs
        }

        [TestMethod]
        public void NegativeIDToString()
        {
            var n1 = new Node(-2345);

            Assert.AreEqual("#-2345", n1.ToString());
            // Not sure if there are supposed to be negative IDs
        }

        [TestMethod]
        public void NodeToString()
        {
            var n1 = new Node(123);

            Assert.AreEqual("#123", n1.ToString());
        }

        [TestMethod]
        public void LongIDToString()
        {
            var n1 = new Node(Int64.MaxValue);

            Assert.AreEqual("#" + Int64.MaxValue, n1.ToString());
        }
    }
}