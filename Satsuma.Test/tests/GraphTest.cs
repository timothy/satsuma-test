// by Wes Thompson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Satsuma;

namespace Satsuma.Test
{
    [TestClass]
    public class GraphTest
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
        public void ID_Mult()
        {
            var n1 = new Node(10);
            var n2 = new Node(15);
            var n3 = new Node(n1.Id*n2.Id);

            Assert.AreEqual(150, n3.Id);
        }

        [TestMethod]
        public void LongIDToString()
        {
            var n1 = new Node(Int64.MaxValue);

            Assert.AreEqual("#" + Int64.MaxValue, n1.ToString());
        }

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
        public void ArcID_Mult()
        {
            var a1 = new Arc(3);
            var a2 = new Arc(5);
            var a3 = new Arc(a1.Id*a2.Id);

            Assert.AreEqual(15, a3.Id);
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
