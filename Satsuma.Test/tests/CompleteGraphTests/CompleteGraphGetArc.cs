//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraphGetArc
	{
		[TestMethod]
		public void UndirectedEqual()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Arc a1 = g.GetArc(g.GetNode(0), g.GetNode(1));
			Arc a2 = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreEqual(a1,a2);
		}

		[TestMethod]
		public void DirectedNotEqual()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a1 = g.GetArc(g.GetNode(0), g.GetNode(1));
			Arc a2 = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreNotEqual(a1, a2);
		}

		[TestMethod]
		public void ArcInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a1 = g.GetArc(g.GetNode(0), g.GetNode(1));
			Arc a2 = g.GetArc(g.GetNode(0), g.GetNode(1));

			Assert.AreEqual(a1, a2);
		}

		[TestMethod]
		public void ArcInvalid()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a1 = g.GetArc(g.GetNode(0), g.GetNode(0));

			Assert.AreEqual(Arc.Invalid, a1);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetArcNodeOutOfGraphShouldThrow()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Node notInGraph = new Node(6);
			
			Arc a1 = g.GetArc(g.GetNode(0), notInGraph);
		}

	}
}
