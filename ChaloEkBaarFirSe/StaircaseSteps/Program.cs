using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaircaseSteps
{
	class Program
	{
		static void Main(string[] args)
		{
			int res = Steps(4);
			int res1 = StepsRecursiveBottomsUp(4);
			int res2 = StepsRecursive(4);
			int res3 = StepsMemoryOptimize(4);
			Console.WriteLine(res);
			Console.WriteLine(res1);
			Console.WriteLine(res2);
			Console.WriteLine(res3);
			Console.ReadKey();
		}
		public static int StepsRecursive(int n)
		{
			if (n == 0)
				return 1;
			if (n < 0)
				return 0;
			int takeStep1 = StepsRecursive(n - 1);
			int takeStep2 = StepsRecursive(n - 2);
			int takeStep3 = StepsRecursive(n - 3);
			return takeStep1 + takeStep2 + takeStep3;

		}

		public static int StepsRecursiveBottomsUp(int n)
		{
			int[] memo = new int[n + 1];
			return StepsRecursiveBottomsUp(n, memo);
		}
		public static int StepsRecursiveBottomsUp(int n, int[] memo)
		{
			Console.WriteLine($"StaticRecursiveBottomsUp({n})");
			if (n == 0)
				return 1;
			if (n < 0)
				return 0;
		if (memo[n] == 0)
			{
				int takeStep1 = StepsRecursiveBottomsUp(n - 1, memo);
				int takeStep2 = StepsRecursiveBottomsUp(n - 2, memo);
				int takeStep3 = StepsRecursiveBottomsUp(n - 3, memo);
				memo[n] = takeStep1 + takeStep2 + takeStep3;
			}
			return memo[n];
		}


		public static int Steps(int n)
		{
			int[] dp = new int[n + 1];
			dp[0] = 1;
			for (int i = 1; i <= n; i++)
			{
				int step1 = dp[i - 1];
				int step3 = i - 2 >= 0 ? dp[i - 2] : 0;
				int step5 = i - 3 >= 0 ? dp[i - 3] : 0;
				//int step3 = i - 3 >=0 ? dp[i - 3] : 0;
				//int step5 = i - 5 >= 0 ? dp[i - 5] : 0;
				dp[i] = step1 + step3 + step5;
			}
			return dp[n];
		}

		public static int StepsMemoryOptimize(int n)
		{
			int n1 = 1;
			int n2 = 1;
			int n3 = 2;
			for (int i = 3; i <= n; i++)
			{
				int temp = n1 + n2 + n3;
				n1 = n2;
				n2 = n3;
				n3 = temp;
			}
			return n3;
		}
	}
}
