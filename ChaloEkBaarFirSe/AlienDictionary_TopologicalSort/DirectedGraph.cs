using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienDictionary_TopologicalSort
{
	class DirectedGraph
	{
		Dictionary<char, List<char>> dict;

		public DirectedGraph()
		{
			dict = new Dictionary<char, List<char>>();
		}

		public void Add(char c1, char c2)
		{
			if (!dict.ContainsKey(c1))
				dict.Add(c1, new List<char>());
			dict[c1].Add(c2);
		}

		public IEnumerable<char> AdjacentElements(char c)
		{
			List<char> list = new List<char>();
			foreach (var ch in dict[c])
			{
				list.Add(ch);
			}
			return list;
		}

	}


}
