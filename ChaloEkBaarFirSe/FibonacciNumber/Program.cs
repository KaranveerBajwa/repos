using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int res = Fib(10);
		}

		public static int Fib(int n)
		{
			int[] fibs = new int[n + 1];
			fibs[0] = 0;
			fibs[1] = 1;
			for (int i = 2; i < fibs.Length; i++)
			{
				fibs[i] = fibs[i - 1] + fibs[i - 2];
			}
			return fibs[n];
		}
	}
}
