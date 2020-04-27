using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienDictionary_TopologicalSort
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = { "z", "a", "z" };//{ "wrt", "wrf", "er", "ett", "rftt" };
			var res = AlienWords(words);
		}

		public static string AlienWords(string[] words)
		{
			Dictionary<char, HashSet<char>> dict = new Dictionary<char, HashSet<char>>();
			var visited = new Dictionary<char, State>();
			for (int i = 0; i < words.Length; i++)
			{
				// loop through all the words and add all the distinct characters to dictionary
				for (int k = 0; k < words[i].Length; k++)
				{
					if (!dict.ContainsKey(words[i][k]))
					{
						dict.Add(words[i][k], new HashSet<char>());
					}
				}
				if ((i + 1) == words.Length)
					break;

				int c = 0;
				int len = Math.Min(words[i].Length, words[i + 1].Length); // get the minimum length between word at 1 and i + 1
				while (c < len && words[i][c] == words[i + 1][c]) // compare the characters and proceed till chat at i and i + 1 are equal
					c++;
				if (c < len)																		// if the counter is less than minimum length of two words add the character
					dict[words[i][c]].Add(words[i + 1][c]);       // from second wordtothe characte at first
			}

			List<char> res = new List<char>();
			foreach (var n in dict.Keys) // loop through all the characters
				if (!visited.ContainsKey(n) && dfs(n,dict, res, visited))  // if the character has not been visited
					return "";   // Run the topological sort and return "" if there is a cycle
			return new string(res.ToArray());
		}
		static bool dfs(char node, Dictionary<char,HashSet<char>> dict, List<char> res , Dictionary<char, State> visited)
		{		 
			visited[node] = State.Visiting;
			foreach (char c in dict[node])
			{
				if (visited.ContainsKey(c))
				{
					if (visited[c] == State.Visiting)
						return true;
				}
				else
				{
					if (dict.ContainsKey(c))
					{
						if (dfs(c, dict, res, visited))
							return true; // if there is a cycle
					}
					else
						res.Insert(0, c);
				}
			}

			res.Insert(0, node);
			visited[node] = State.Visited;
			return false;
		}

		enum State {
			NotVisited,
			Visiting,
			Visited
		}
	
	}
}
