using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			GenerateParen("((()))");
			var result = GenerateParenthesis(3);
			foreach (var r in result)
				Console.WriteLine(r);
			Console.ReadKey();		
		}

		public static void GenerateParen(string s)
		{
			char[] buffer = new char[s.Length];
			bool[] visited = new bool[s.Length];
			HashSet<string> set = new HashSet<string>();
			GenerateParens(s, buffer, 0, 0, set, visited);
		}

		static void GenerateParens(string s, char[] buffer, int bufferIndex, int lc, HashSet<string> set, bool[] visited)
		{
			if (bufferIndex == buffer.Length && lc ==0)
			{
				set.Add(new string(buffer));
				return;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!visited[i])
				{
					if (s[i] == ')' && lc > 0)
					{
						buffer[bufferIndex] = s[i];
						visited[i] = true;
						GenerateParens(s, buffer, bufferIndex + 1, lc-1, set, visited);
					}
					else
					{
						buffer[bufferIndex] = s[i];
						visited[i] = true;
						GenerateParens(s, buffer, bufferIndex + 1, lc + 1,  set, visited);
					}
					visited[i] = false;
				}
			}

		}

		public static List<string> GenerateParenthesis(int n)
		{
			char[] buffer = new char[2 * n];
			HashSet<string> set = new HashSet<string>();
			GenerateParenthesisHelper(buffer,0,0,0,n,set);
			return set.ToList();
		}

		static void GenerateParenthesisHelper(char[] buffer, int bufferIndex, int open, int close, int max, HashSet<string> set)
		{
			if (bufferIndex == buffer.Length)
			{
				set.Add(new string(buffer));
				Console.Write("I am here");
				return;
			}
			if (open < max)
			{
				buffer[bufferIndex] = '(';
				GenerateParenthesisHelper(buffer, bufferIndex + 1, open + 1, close, max, set);
			}
			if (close < open)
			{
				buffer[bufferIndex] = ')';
				GenerateParenthesisHelper(buffer, bufferIndex + 1, open, close + 1, max, set);
			}


		}

	}
}
