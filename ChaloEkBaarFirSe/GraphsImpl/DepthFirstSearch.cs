using System;
using System.Collections.Generic;
using System.Text;

namespace GraphsImpl
{
	public static class DepthFirstSearch
	{
		

		public static bool dfs(Graph g, int target)
		{
			bool[] visited = new bool[g.VertexCount+1] ;
			for (int i = 1; i < g.VertexCount; i++)
			{
 
					if (!visited[i] && dfsVisit(g, target, i, visited))
						return true;
			 
			}
			return false;
		}

		public static bool dfsVisit(Graph g, int target,int i, bool[] visited)
		{
			visited[i] = true;
			if (i == target)
			{
				return true;

			}
			foreach (var v in g.Neighbors(i))
			{
				if (!visited[v] && dfsVisit(g, target, v, visited))
				{
					return true;			
				}	
			}
			return false;
		}

	}
}
