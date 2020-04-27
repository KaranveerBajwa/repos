using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectedGraph;
namespace SchedulinOrders
{
	class Program
	{
		static void Main(string[] args)
		{
			//Tasks=6, Prerequisites=[2, 5], [0, 5], [0, 4], [1, 4], [3, 2], [1, 3]


			/*
			 * Input: Tasks=6, Prerequisites=[2, 5], [0, 5], [0, 4], [1, 4], [3, 2], [1, 3]
Output: 
1) [0, 1, 4, 3, 2, 5]
2) [0, 1, 3, 4, 2, 5]
3) [0, 1, 3, 2, 4, 5]
4) [0, 1, 3, 2, 5, 4]
5) [1, 0, 3, 4, 2, 5]
6) [1, 0, 3, 2, 4, 5]
7) [1, 0, 3, 2, 5, 4]
8) [1, 0, 4, 3, 2, 5]
9) [1, 3, 0, 2, 4, 5]
10) [1, 3, 0, 2, 5, 4]
11) [1, 3, 0, 4, 2, 5]
12) [1, 3, 2, 0, 5, 4]
13) [1, 3, 2, 0, 4, 5]
			 * */
			DAG graph = new DAG(6);
			graph.Add(2, 5);
			graph.Add(0, 5);
			graph.Add(0, 4);
			graph.Add(1, 4);
			graph.Add(3, 2);
			graph.Add(1, 3);
			var res = SchedulingOrder(graph);
		}

		public static List<int> SchedulingOrder(DAG g)
		{
			Stack<int> stack = new Stack<int>();
			bool[] visited = new bool[g.Vertex];
			for (int i = 0; i < g.Vertex; i++)
			{
				if (!visited[i])
					SchedulingOrderHelper(g, i, visited, stack);		
			}
			return stack.ToList();
		
		}

		static void SchedulingOrderHelper(DAG g, int i, bool[] visited, Stack<int> stack)
		{
			visited[i] = true;
			foreach (int j in g.Neighbors(i))
			{
				if (!visited[j])
					SchedulingOrderHelper(g, j, visited, stack);
			}
			stack.Push(i);
		}
	}
}
