using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseTheif
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] houses = { 2, 5, 1, 3,6, 2, 4};
			int[] houses1 = { 2, 10, 14, 8, 1 };
			int res1 = MaxSteal(houses);
			int res2 = MaxSteal(houses1);
		}

		// for given index 
		// steal and skip 2
		// skip and skip 1
		// get the max of 2

		public static int MaxSteal(int[] houses)
		{
			if (houses == null || houses.Length == 0)
				return 0;
			var res1 = MaxStealRecursive(houses, 0);
			int[] dp = new int[houses.Length];
			var res2 = MaxStealRecursiveBottomsUp(houses, 0, dp);
			return res1;
		}
		static int MaxStealRecursive(int[] houses, int curIndex)
		{
			if (curIndex >= houses.Length)
				return 0;
			int skip2 = houses[curIndex] + MaxStealRecursive(houses, curIndex + 2);
			int skip1 = MaxStealRecursive(houses, curIndex + 1);
			return Math.Max(skip1, skip2);
		}
		static int MaxStealRecursiveBottomsUp(int[] houses, int curIndex, int[] dp)
		{
			if (curIndex >= houses.Length)
				return 0;
			if (dp[curIndex] == 0)
			{
				int skip2 = houses[curIndex] + MaxStealRecursiveBottomsUp(houses, curIndex + 2, dp);
				int skip1 = MaxStealRecursiveBottomsUp(houses, curIndex + 1, dp);
				dp[curIndex] = Math.Max(skip1, skip2);
			}
			return dp[curIndex];
		}


	}
}
