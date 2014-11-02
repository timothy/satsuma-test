//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_Arcs_OneNode
	{
		#region arcs1
		[TestMethod]
		public void UndirectedAll()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void UndirectedEdge()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void DirectedAll()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void DirectedEdge()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void ArcsInvariant()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs1 = g.Arcs(ArcFilter.All);
			var arcs2 = g.Arcs(ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}

		#endregion
		#region arcs2
		[TestMethod]
		public void FromNodeUndirectedAll()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedEdge()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedBackward()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedForward()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedAll()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedEdge()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedBackward()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedForward()
		{
			var g = new CompleteGraph(1, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeArcsInvariant()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			var arcs1 = g.Arcs(g.GetNode(0), ArcFilter.All);
			var arcs2 = g.Arcs(g.GetNode(0), ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}
		#endregion
	}
}

