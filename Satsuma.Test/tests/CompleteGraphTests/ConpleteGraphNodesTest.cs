using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class ConpleteGraphNodesTest
	{
		[TestMethod]
		public void ZeroNodes()
		{
			var g = new CompleteGraph(0, Directedness.Directed);

			int count = g.Nodes().Count();

			Assert.AreEqual(count, 0);
		}

		[TestMethod]
		public void OneNode()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			int count = g.Nodes().Count();

			Assert.AreEqual(count, 1);
		}

		[TestMethod]
		public void FiveNodes()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int count = g.Nodes().Count();

			Assert.AreEqual(count, 5);
		}

		[TestMethod]
		public void CountZeroNodes()
		{
			var g = new CompleteGraph(0, Directedness.Directed);

			Assert.AreEqual(g.NodeCount(), 0);
		}

		[TestMethod]
		public void CountOneNode()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			Assert.AreEqual(g.NodeCount(), 1);
		}

		[TestMethod]
		public void CountFiveNodes()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Assert.AreEqual(g.NodeCount(), 5);
		}

		[TestMethod]
		public void NodesAreDistinct()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var distinctNodes = g.Nodes().Distinct().ToList();

			CollectionAssert.AreEqual(distinctNodes,g.Nodes().ToList());
		}
	}
}
