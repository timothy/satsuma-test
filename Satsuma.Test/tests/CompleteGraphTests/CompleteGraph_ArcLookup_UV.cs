//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_ArcLookup_UV
	{
		[TestMethod]
		public void UndirectedU01()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Arc a = g.GetArc(g.GetNode(0),g.GetNode(1));

			Assert.AreEqual(g.GetNode(0),g.U(a));
		}

		[TestMethod]
		public void UndirectedU10()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Arc a = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreEqual(g.GetNode(0),g.U(a));
		}

		[TestMethod]
		public void DirectedU01()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a = g.GetArc(g.GetNode(0), g.GetNode(1));

			Assert.AreEqual(g.GetNode(0), g.U(a));
		}

		[TestMethod]
		public void DirectedU10()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreEqual(g.GetNode(1), g.U(a));
		}

		[TestMethod]
		public void UndirectedV01()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Arc a = g.GetArc(g.GetNode(0), g.GetNode(1));

			Assert.AreEqual(g.GetNode(1), g.V(a));
		}

		[TestMethod]
		public void UndirectedV10()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Arc a = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreEqual(g.GetNode(1), g.V(a));
		}

		[TestMethod]
		public void DirectedV01()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a = g.GetArc(g.GetNode(0), g.GetNode(1));

			Assert.AreEqual(g.GetNode(1), g.V(a));
		}

		[TestMethod]
		public void DirectedV10()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			Arc a = g.GetArc(g.GetNode(1), g.GetNode(0));

			Assert.AreEqual(g.GetNode(0), g.V(a));
		}
	}
}
