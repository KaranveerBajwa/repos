using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSubsetSumPartition
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 4 };
			var res = CanPartition(nums);
		//	var res2 = CanPartitionTopDown(nums);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static bool CanPartition(int[] nums)
		{
			// calculate the sum , get the half of sum
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}
			if (sum % 2 != 0)
				return false;
			int halfSum = sum / 2;
			return CanPartitionHelper(nums, halfSum,0);
		}

		static bool CanPartitionHelper(int[] nums, int sum, int curIndex)
		{
			if (sum == 0)
				return true;
			if (curIndex >= nums.Length)
				return false;
			int temp = sum - nums[curIndex];
			if (temp >= 0)
				if (CanPartitionHelper(nums, temp, curIndex + 1))
					return true;
			return CanPartitionHelper(nums, sum, curIndex + 1);

		}


		public





		static bool CanPartitionTopDown(int[] nums)
		{
			// calculate the half of sum of array 
			//create a memo matrix
			// initate the recursive call
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}

			int halfSum = sum / 2;
			bool?[,] dp = new bool?[nums.Length, halfSum + 1];
			return CanPartitionHelperTopDown(nums, halfSum,dp,0);
		}

		static bool CanPartitionHelperTopDown(int[] nums, int sum, bool?[,] dp, int curIndex)
		{
			if (sum == 0)
				return true;
			if (curIndex == nums.Length || sum < 0)
				return false;
			if (dp[curIndex, sum] != null)
				return dp[curIndex, sum].Value;
			if (nums[curIndex] <= sum)
			{
				if (CanPartitionHelperTopDown(nums, sum - nums[curIndex], dp, curIndex + 1))
				{
					dp[curIndex, sum] = true;
					return true;
				}
			}
			dp[curIndex, sum] = CanPartitionHelperTopDown(nums, sum, dp, curIndex + 1);
			return dp[curIndex, sum].Value;
		}
	
	}
}
