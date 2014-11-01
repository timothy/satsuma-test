// by Matthew Draper
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Satsuma;

namespace Satsuma.Test
{
	[TestClass]
	public class CompleteGraphConstructorTest
	{
		[TestMethod]
		public void CreateUndirected()
		{
			var g = new CompleteGraph(0, Directedness.Undirected);

			Assert.AreEqual(g.Directed, false);
		}

		[TestMethod]
		public void CreateDirected()
		{
			var g = new CompleteGraph(0, Directedness.Directed);

			Assert.AreEqual(g.Directed, true);
		}

		[TestMethod]
		public void ZeroNumNodes()
		{
			var g = new CompleteGraph(0, Directedness.Undirected);

			Assert.AreEqual(0, g.NodeCount());
		}

		[TestMethod]
		public void OneNumNodes()
		{
			var g = new CompleteGraph(1, Directedness.Undirected);

			Assert.AreEqual(1, g.NodeCount());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void MaxNumNodes()
		{
			var g = new CompleteGraph(Int32.MaxValue, Directedness.Undirected);

			Assert.AreEqual(Int32.MaxValue, g.NodeCount());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void NegativeOneException()
		{
			var g = new CompleteGraph(-1, Directedness.Undirected);
		}
	}
}
