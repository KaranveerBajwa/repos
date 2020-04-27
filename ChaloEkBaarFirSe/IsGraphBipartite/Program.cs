using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphsImpl;
namespace IsGraphBipartite
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph g = new Graph(7);
			g.AddEdge(0, 1);
			g.AddEdge(0, 5);
			g.AddEdge(0, 6);
			g.AddEdge(0, 2);
			g.AddEdge(6, 4);
			g.AddEdge(4, 5);
			g.AddEdge(5, 3);
			g.AddEdge(3, 4);
			BreadthFirstSearch bfs = new BreadthFirstSearch(g, 0);
			int[][] graph = new int[4][];
			graph[0] = new int[]{ 1,2,3 };
			graph[1] = new int[] {0,2 };
			graph[2] = new int[] { 0,1, 3 };
			graph[3] = new int[]{0,2 };
			var res = IsBipartite(graph);

			int[][] graph1 = new int[4][];
			graph1[0] = new int[] { 1,  3 };
			graph1[1] = new int[] { 0, 2 };
			graph1[2] = new int[] {  1, 3 };
			graph1[3] = new int[] { 0, 2 };
			var res1 = IsBipartite(graph1);
		}

		public static bool IsBipartite(int[][] graph)
		{
			if (graph == null || graph.Length == 0)
				return true;
			bool[] visited = new bool[graph.Length];
			int[] distTo = new int[graph.Length];
			Queue<int> queue = new Queue<int>();
			queue.Enqueue(0);
			visited[0] = true;
			while(queue.Count >0)
			{ 
				int n = queue.Dequeue();
				for (int j = 0; j < graph[n].Length; j++)
				{
					if (!visited[graph[n][j]])
					{
						queue.Enqueue(graph[n][j]);
						distTo[graph[n][j]] = distTo[n] + 1;
						visited[graph[n][j]] = true;
					}
					else if (distTo[n] == distTo[graph[n][j]])
							return false;
				}
			}
			return true;

			
		}
	}
}
