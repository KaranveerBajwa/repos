using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC862_ShortestSubArrayToMaxSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 2, -1, 2 };
			int target = 3;
			int result = ShortestSubarray(nums, target);
			Console.WriteLine(result);
			Console.ReadKey();		
		}

		public static int ShortestSubarray(int[] nums, int target)
		{
			int minSumLength = Int32.MaxValue;
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(0, -1);
			int sum = 0;
			int right = -1;
			int left = 0;
			while (right < nums.Length -1)
			{
				right++;
				sum += nums[right];
				if (sum - target > 0)
				{
					sum = sum - nums[left];
					left++;
				}
				if (dict.ContainsKey(sum - target))
				{
					int length = dict[sum - target] <0 ? right + 1 : right - dict[sum - target] + 1;
					if (length < minSumLength)
						minSumLength = length;
					sum = sum - nums[left];
					left++;
				}
				else
					dict.Add(sum, right);
			}

			minSumLength = minSumLength == Int32.MaxValue ? -1 : minSumLength;
			return minSumLength;
		}
	}
}
