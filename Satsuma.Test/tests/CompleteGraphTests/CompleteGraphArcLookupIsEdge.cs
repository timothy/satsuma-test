using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraphArcLookupIsEdge
	{
		[TestMethod]
		public void IsEdgeUndirected()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			foreach( Arc a in g.Arcs(ArcFilter.All) )
			{
				Assert.IsTrue(g.IsEdge(a));
			}
		}

		[TestMethod]
		public void IsEdgeDirected()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			foreach( Arc a in g.Arcs(ArcFilter.All) )
			{
				Assert.IsFalse(g.IsEdge(a));
			}
		}
	}
}
