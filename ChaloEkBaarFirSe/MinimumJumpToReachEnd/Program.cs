using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumJumpToReachEnd
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {2, 3, 1, 1, 4};
			var res = MinimumJumps(arr);
			Console.WriteLine(res);
			var res2 = MinimumJumpRecursive(arr);
			Console.WriteLine(res2);
			Console.ReadKey();
		}

		public static int MinimumJumpRecursive(int[] jumps)
		{
			if (jumps == null || jumps.Length == 0)
				return 0;
			return MinimumJumpsRecursiveHelper(jumps, 0);
		}

		static int MinimumJumpsRecursiveHelper(int[] jumps, int curIndex)
		{
			if (curIndex == jumps.Length-1)
				return 0;
			if (jumps[curIndex] == 0)
				return Int32.MaxValue;
			int totalJumps = Int32.MaxValue;
			int start = curIndex + 1;
			int end = curIndex + jumps[curIndex];
			while (start < jumps.Length && start <= end)
			{
				int minJumps = MinimumJumpsRecursiveHelper(jumps, start++);
				if (minJumps != Int32.MaxValue)
					totalJumps = Math.Min(totalJumps, minJumps + 1);
			}
			return totalJumps;

		}


		public static int MinimumJumps(int[] arr)
		{
			// create memo array of size arr.Length + 1
			int[] memo = new int[arr.Length ];
			// update array with max values
			for (int i = 1; i < arr.Length; i++)
				memo[i] = Int32.MaxValue;
			// do two loops 
				//from start 0 to arr.Length
					// from start+1 to arr.Length
			for(int i =0; i < arr.Length -1; i++)
			{
				for (int j = i + 1; j <= i + arr[i] && j < arr.Length; j++)
				{
					memo[j] = Math.Min(memo[j], memo[i] + 1);
				}
			}
			return memo[memo.Length - 1];
					 // compare the value at the give index and update with minimum value
					 //  return the last array element
		}
	}
}
