//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_HasNode
	{
		[TestMethod]
		public void HasAllNodes()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			foreach( Node n in g.Nodes() )
			{
				Assert.IsTrue(g.HasNode(n));
			}
		}

		[TestMethod]
		public void NotHaveNodeAbove()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Node n = new Node(6);

			Assert.IsFalse(g.HasNode(n));
		}

		[TestMethod]
		public void NotHaveNodeBelow()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Node n = new Node(-1);

			Assert.IsFalse(g.HasNode(n));
		}
	}
}
