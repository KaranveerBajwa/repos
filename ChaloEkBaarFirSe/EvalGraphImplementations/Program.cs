using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphsImpl;
namespace EvalGraphImplementations
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph g = new Graph(7);
			g.Add(1, 2);
			g.Add(1, 3);
			g.Add(2, 4);
			g.Add(3, 4);
			g.Add(3, 5);
			g.Add(5, 6);
			g.Add(4, 6);
			var result = DepthFirstSearch.dfs(g, 9); 
		}
	}
}
