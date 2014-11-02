//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_ArcCount
	{
		#region arcs1
		[TestMethod]
		public void UndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(ArcFilter.All);

			Assert.AreEqual(10, arcs);
		}

		[TestMethod]
		public void UndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(ArcFilter.Edge);

			Assert.AreEqual(10, arcs);
		}

		[TestMethod]
		public void DirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(ArcFilter.All);

			Assert.AreEqual(20, arcs);
		}

		[TestMethod]
		public void DirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(ArcFilter.Edge);

			Assert.AreEqual(0, arcs);
		}

		[TestMethod]
		public void ArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs1 = g.ArcCount(ArcFilter.All);
			int arcs2 = g.ArcCount(ArcFilter.All);

			Assert.AreEqual(arcs1, arcs2);
		}

		#endregion
		#region arcs2
		[TestMethod]
		public void FromNodeUndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeUndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeUndirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeUndirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeDirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(8, arcs);
		}

		[TestMethod]
		public void FromNodeDirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Edge);

			Assert.AreEqual(0, arcs);
		}

		[TestMethod]
		public void FromNodeDirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Backward);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeDirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), ArcFilter.Forward);

			Assert.AreEqual(4, arcs);
		}

		[TestMethod]
		public void FromNodeArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs1 = g.ArcCount(g.GetNode(0), ArcFilter.All);
			int arcs2 = g.ArcCount(g.GetNode(0), ArcFilter.All);

			Assert.AreEqual(arcs1, arcs2);
		}
		#endregion
		#region arcs3
		[TestMethod]
		public void NodeToNodeUndirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.All);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeUndirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Edge);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeUndirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Backward);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeUndirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Forward);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeDirectedAll()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.All);

			Assert.AreEqual(2, arcs);
		}

		[TestMethod]
		public void NodeToNodeDirectedEdge()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Edge);

			Assert.AreEqual(0, arcs);
		}

		[TestMethod]
		public void NodeToNodeDirectedBackward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Backward);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeDirectedForward()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			int arcs = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.Forward);

			Assert.AreEqual(1, arcs);
		}

		[TestMethod]
		public void NodeToNodeArcsInvariant()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			int arcs1 = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.All);
			int arcs2 = g.ArcCount(g.GetNode(0), g.GetNode(1), ArcFilter.All);

			Assert.AreEqual(arcs1, arcs2);
		}
		#endregion
	}
}
