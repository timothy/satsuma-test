// by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_Arcs_ZeroNodes
	{
		#region arcs1
		[TestMethod]
		public void UndirectedAll()
		{
			var g = new CompleteGraph(0, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void UndirectedEdge()
		{
			var g = new CompleteGraph(0, Directedness.Undirected);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void DirectedAll()
		{
			var g = new CompleteGraph(0, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.All);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void DirectedEdge()
		{
			var g = new CompleteGraph(0, Directedness.Directed);

			var arcs = g.Arcs(ArcFilter.Edge);

			Assert.AreEqual(0, arcs.Count());
		}

		[TestMethod]
		public void ArcsInvariant()
		{
			var g = new CompleteGraph(0, Directedness.Undirected);

			var arcs1 = g.Arcs(ArcFilter.All);
			var arcs2 = g.Arcs(ArcFilter.All);

			CollectionAssert.AreEqual(arcs1.ToList(), arcs2.ToList());
		}

		#endregion
	}
}

