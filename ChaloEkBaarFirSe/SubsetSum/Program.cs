using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 7, };
			var res = SubsetSumBottomsUp(nums, 10);
			int[] nums1 = {1, 3, 4, 8 };
			var res2 = SubsetSumBottomsUp(nums, 6);
			Console.WriteLine(res);
			Console.WriteLine(res2);

			var res3 = SubsetSumRecursive(nums, 10);
			var res4 = SubsetSumRecursive(nums1, 6);
			Console.WriteLine(res3);
			Console.WriteLine(res4);
			
			Console.ReadKey();
		
		}

		public static bool SubsetSumRecursive(int[] nums, int sum)
		{
			return SubsetSumRecursiveHelper(nums, sum, 0);
		}
		public static bool SubsetSumRecursiveHelper(int[] nums, int sum, int curIndex)
		{
			if (sum == 0)
				return true;
			if (curIndex >= nums.Length || sum <=0)
				return false;

			if (nums[curIndex] <= sum)
				if (SubsetSumRecursiveHelper(nums, sum - nums[curIndex], curIndex + 1))
					return true;
			return SubsetSumRecursiveHelper(nums, sum, curIndex + 1);
		}

		public static bool SubsetSumBottomsUp(int[] nums, int sum)
		{
			bool[,] dp = new bool[nums.Length, sum + 1];
			return SubsetSumBottomsUpHelper(nums, sum, 0, dp);
		}

		static bool SubsetSumBottomsUpHelper(int[] nums, int sum, int curIndex, bool[,] dp)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				dp[i, 0] = true;
			}
			for (int i = 1; i <= sum; i++)
			{
				dp[0, i] = nums[0] == sum ? true : false;
			}
			for (int i = 1; i < nums.Length; i++)
				for (int j = 1; j <= sum; j++)
				{
					if (dp[i - 1, j])
						dp[i, j] = dp[i - 1, j];
					else if (nums[i] <= j)
					{
						dp[i, j] = dp[i - 1, j - nums[i]];
					}
				}
			return dp[nums.Length - 1, sum];
		}
	
		// Subset Bootomsup memory optimize
		// declare dp of size sum + 1
		//set dp[0] = true; and populate dp from 1 till end if sum == nums[0]
		// loop through numbers from 1 (i)
			// loop through sum (j)
				// if dp[j] is not true and j >= nums[i]
					// dp[j - nums[i]]
	
	}
}
