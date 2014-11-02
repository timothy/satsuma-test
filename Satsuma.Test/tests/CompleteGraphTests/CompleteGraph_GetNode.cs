//by Matthew Drper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Satsuma;

namespace Satsuma.Test.tests
{
	[TestClass]
	public class CompleteGraph_GetNode
	{
		[TestMethod]
		public void GetNodeNormal()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var node = g.GetNode(0);

			Assert.IsNotNull(node);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetNodeAboveRange()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var node = g.GetNode(1);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetNodeBelowRange()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var node = g.GetNode(-1);
		}

		[TestMethod]
		public void GetNodeEqual()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var node1 = g.GetNode(0);
			var node2 = g.GetNode(0);

			Assert.IsTrue(node1 == node2);
		}

		[TestMethod]
		public void GetNodeNotEqual()
		{
			var g = new CompleteGraph(2, Directedness.Undirected);

			var node1 = g.GetNode(0);
			var node2 = g.GetNode(1);

			Assert.IsTrue(node1 != node2);
		}
	}
}
