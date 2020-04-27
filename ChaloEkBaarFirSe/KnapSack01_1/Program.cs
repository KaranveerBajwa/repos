using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapSack01_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] weights = { 1,2,3,5};
			int[] profits = { 1, 6, 10, 16 };
			int capacity = 7;
			int res = KnapSackRecursive(weights, profits, capacity);
			int res2 = KnapsackBottomsUp(weights, profits, capacity);
			Console.WriteLine(res);
			Console.WriteLine(res2);
			Console.ReadKey();
		}

		#region Knapsack Recursive
		//time complexity : 2 raised power n
		// Space complexity: Depth os recursion: O(n)

		public static int KnapSackRecursive(int[] weights, int[] profits, int capacity)
		{
			return KnapSackRecursiveHelper(weights, profits, capacity, 0);
		}

		static int KnapSackRecursiveHelper(int[] weights, int[] profits, int capacity, int curIndex)
		{
			if (capacity <= 0 || curIndex == weights.Length)
				return 0;
			int profit1 = 0;
			if (weights[curIndex] <= capacity)
				profit1 = profits[curIndex] + KnapSackRecursiveHelper(weights, profits, capacity - weights[curIndex], curIndex + 1);
			int profit2 = KnapSackRecursiveHelper(weights, profits, capacity, curIndex + 1);
			return Math.Max(profit1, profit2);
		}
		#endregion Knapsackrecursive

		#region Memoization TopDown
		// As we encounter the overlapping subproblems  in our recursion , 
		// we can save time and use already calculated values, we store and do top down
		// dp[profits.Length, capacity + 1]


		#endregion

		#region Memoization BottomsUp
		public static int KnapsackBottomsUp(int[] weights, int[] profits, int capacity)
		{
			int[,] dp = new int[profits.Length, capacity + 1];
			return KnapsackBottomsUpHelper(weights, profits, capacity, dp);
		}

		static int KnapsackBottomsUpHelper(int[] weights, int[] profits, int capacity, int[,] dp)
		{
			int rows = dp.GetLength(0);
			int cols = dp.GetLength(1);
			// intitialize  column with 0 capacity
			for (int i = 0; i < rows; i++)
			{
				dp[i, 0] = 0;
			}
			// if we have only one weight
			for (int i = 0; i < cols; i++)  // cols contains capacity
			{
				if (weights[0] <= i)
					dp[0, i] = profits[0];
			}
			for (int i = 1; i < rows; i++)
				for (int j = 1; j <=capacity; j++) // for each capacity
				{
					if (weights[i] <= j)
					{
						dp[i, j] = Math.Max(profits[i] + dp[i - 1, j - weights[i]], dp[i - 1, j]);
					}
					else
						dp[i, j] = dp[i - 1, j];
				}

			return dp[rows - 1, capacity];
		}
	}
		#endregion

	}
