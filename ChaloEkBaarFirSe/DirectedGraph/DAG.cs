using System;
using System.Collections.Generic;
namespace DirectedGraph
{
	public class DAG
	{
		List<int>[] adj;
		public int Vertex;
		public DAG(int size)
		{
			adj = new List<int>[size];
			for (int i = 0; i < size; i++)
			{
				adj[i] = new List<int>();
			}
			Vertex = size;
		}

		public void Add(int u, int v)
		{
			adj[u].Add(v);		
		}

		public IEnumerable<int> Neighbors(int n)
		{
			return adj[n];
		}
	}
}
