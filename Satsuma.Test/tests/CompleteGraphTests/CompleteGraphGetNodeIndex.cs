using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Satsuma;

namespace Satsuma.Test.tests
{
	[TestClass]
	public class CompleteGraphGetNodeIndex
	{
		[TestMethod]
		public void IndexEquals()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);

			Node n = g.GetNode(0);
			int index = g.GetNodeIndex(n);

			Assert.AreEqual(index, 0);
		}
		[TestMethod]
		public void IndexInRange()
		{
			var g = new CompleteGraph(5, Directedness.Undirected);
			foreach( Node n in g.Nodes() )
			{
				int index = g.GetNodeIndex(n);
				Assert.IsTrue(0 <= index && index < 5);
			}
		}
	}
}
