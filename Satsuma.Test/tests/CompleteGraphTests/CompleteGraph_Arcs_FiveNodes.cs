//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_Arcs_FiveNodes
	{
		#region arcs1
		[TestMethod]
		public void UndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(10, arcs.Count());
		}

		[TestMethod]
		public void UndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(10, arcs.Count());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void UndirectedBackwardShouldThrow()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.Backward);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void UndirectedForwardShouldThrow()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.Forward);
		}

		[TestMethod]
		public void DirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(20, arcs.Count());
		}

		[TestMethod]
		public void DirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void DirectedBackwardShouldThrow()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.Backward);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void DirectedForwardShouldThrow()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.Forward);
		}

		[TestMethod]
		public void ArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs1 = g.Arcs(ArcFilter.All);
			var arcs2 = g.Arcs(ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}

		#endregion
		#region arcs2
		[TestMethod]
		public void FromNodeUndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0),ArcFilter.All);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeUndirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(8, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeDirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(4, arcs.Count());
		}

		[TestMethod]
		public void FromNodeArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs1 = g.Arcs(g.GetNode(0), ArcFilter.All);
			var arcs2 = g.Arcs(g.GetNode(0), ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}
		#endregion
		#region arcs3
		[TestMethod]
		public void NodeToNodeUndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.All);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeUndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Edge);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeUndirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Backward);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeUndirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Forward);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeDirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.All);

			Assert.AreEqual(2, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeDirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeDirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Backward);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeDirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			var arcs = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.Forward);

			Assert.AreEqual(1, arcs.Count());
		}

		[TestMethod]
		public void NodeToNodeArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			var arcs1 = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.All);
			var arcs2 = g.Arcs(g.GetNode(0),g.GetNode(1),ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}
		#endregion
	}
}
