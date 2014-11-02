//by Matthew Draper
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Satsuma.Test.tests.CompleteGraphTests
{
	[TestClass]
	public class CompleteGraph_HasArc
	{
		[TestMethod]
		public void HasAllArcsUndirected()
		{
			var g = new CompleteGraph(5,Directedness.Undirected);

			foreach( Arc a in g.Arcs(ArcFilter.All) )
			{
				Assert.IsTrue(g.HasArc(a));
			}
		}

		[TestMethod]
		public void HasAllArcsDirected()
		{
			var g = new CompleteGraph(5, Directedness.Directed);

			foreach( Arc a in g.Arcs(ArcFilter.All) )
			{
				Assert.IsTrue(g.HasArc(a));
			}
		}
	}
}
