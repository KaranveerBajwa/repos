using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallsAndGates
{
	class Program
	{
		static void Main(string[] args)
		{
		}
		//{functionid, start/end: timestamp}
		public int[] ExclusiveTime(int n, IList<string> logs)
		{
			int[] res = new int[n];
			int i = 1; // track the iteration
			Stack<int> stack = new Stack<int>();// to track the id of function
			string[] s = logs[0].Split(':');
			stack.Push(Convert.ToInt32(s[0]));
			int prev = Convert.ToInt32(s[2]);
			while (i < logs.Count)
			{
				s = logs[i].Split(':');
				if (s[1] == "start")
				{
					if (stack.Count > 0)
					{
						res[stack.Peek()] += Convert.ToInt32(s[2]) - prev;
					}
					stack.Push(Convert.ToInt32(s[0]));
					prev = Convert.ToInt32(s[2]);
				}
				else
				{
					res[stack.Peek()] += Convert.ToInt32(s[2]) - prev + 1;
					stack.Pop();
					prev = Convert.ToInt32(s[2]) + 1;
				}
				i++;
			
			}
			return res;
		}
	}
}
