using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifyPath
{
	class Program
	{
		static void Main(string[] args)
		{
		}
		public static string SimplifyPath(string s)
		{
			string[] str = s.Split('/');
			Stack<string> stack = new Stack<string>();
			foreach (string dir in str)
			{
				if (String.IsNullOrEmpty(dir) || dir == ".")
					continue;
				else if (dir == "..")
				{
					if (stack.Count > 0)
						stack.Pop();
				}
				else
					stack.Push(dir);
			}

			StringBuilder sb = new StringBuilder();
			while (stack.Count > 0)
			{
				sb.Insert(0, stack.Pop());
				sb.Insert(0, "/");
			}
			return sb.Length > 0 ? sb.ToString(): "/";

		}

	}
}
