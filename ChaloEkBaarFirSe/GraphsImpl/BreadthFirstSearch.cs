using System;
using System.Collections.Generic;
using System.Text;

namespace GraphsImpl
{
	public class BreadthFirstSearch
	{
		bool[] visited;
		int[] distTo;
		int[] edgeTo;
		int Source;
		public BreadthFirstSearch(Graph g, int source)
		{
			Source = source;
			edgeTo = new int[g.VertexCount];
			distTo = new int[g.VertexCount];
			visited = new bool[g.VertexCount];
			var res = bfs(g, source);
		}

		public bool bfs(Graph g, int source)
		{
			Queue<int> queue = new Queue<int>();
			List<int> evenList = new List<int>();
			List<int> oddList = new List<int>();
			queue.Enqueue(source);
			visited[source] = true;
			while (queue.Count > 0)
			{
				var n = queue.Dequeue();
				foreach (var v in g.AdjacentElements(n))
				{
					if (!visited[v])
					{
						queue.Enqueue(v);
						distTo[v] = distTo[n] + 1;
						if (distTo[v] % 2 == 0)
							evenList.Add(v);
						else
							oddList.Add(v);
						edgeTo[n] = n;
						visited[v] = true;
					}
					else if (distTo[n] == distTo[v])
						return true;
				}
			}
			return false;
		}
	}
}
