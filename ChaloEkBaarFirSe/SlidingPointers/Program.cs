using System;
using Utils;
namespace SlidingPointers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 3, 7, 4, 5, 1, 7 };
			var res = SubArraySumToTarget(nums,6);
			ArrayHelper.PrintArray(res);
			Console.ReadKey();
		}
		#region SubarraySumToTarget
		static int[] SubArraySumToTarget(int[] nums, int target)
		{
			int start = 0;
			int end = 0;
			int sum = nums[0];

			while (end < nums.Length)
			{
				if (start > end)
				{
					end = start;
					sum = nums[start];
				}
				if (sum < target && end < nums.Length - 1)
				{
					end++;
					sum += nums[end];
				}
				else if (sum > target)
				{
					sum = sum - nums[start];
					start++;
				}
				else
					break;
				// if start goes past end set end= start and sum = value at atart
				// increment right if sum is less
				// subtract left most element, increment left if sum is greater 
				// if sum equals target break and generate the array
			}
			int j = 0;

			int[] result =new int[end - start + 1];
			
			for (int i = start; i <= end; i++, j++)
			{
				result[j] = nums[i];
			}
			return result;

		}
		#endregion
	}
}
