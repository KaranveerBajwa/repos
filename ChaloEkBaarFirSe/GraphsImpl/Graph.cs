using System.Collections.Generic;
namespace GraphsImpl
{
	public class Graph
	{
		public List<int>[] adj;
		public int VertexCount;
		int EdgeCount;

		public Graph(int size)
		{
			adj = new List<int>[size];
			VertexCount = size;
			EdgeCount = 0;
			for (int i = 0; i < size; i++)
			{
				adj[i] = new List<int>();
			}
		}

		public void Add(int u, int v)
		{
			adj[u].Add(v);
			adj[v].Add(u);
			EdgeCount = EdgeCount + 2;
		}

		public IEnumerable<int> Neighbors(int n)
		{
			return adj[n];
		}

	
	}

}