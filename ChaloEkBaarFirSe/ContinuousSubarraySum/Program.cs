using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousSubarraySum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 23, 2, 4, 6, 7};
			int k = 6;
			var res = CheckSubarraySum(nums, k);
			int[] nums1 = { 23,6,9};
			int k1 =6;
			var res1 = CheckSubarraySum(nums1, k1);
		}

		public static bool CheckSubarraySum(int[] nums, int k)
		{
			Dictionary<int, int> sums = new Dictionary<int, int>();
			sums.Add(0, -1);
			int sum = 0;
				for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				if (k != 0)
					sum = sum % k;
				if (sums.ContainsKey(sum))
				{
					if (i - sums[sum] > 1)
						return true;
				}
				else
					sums.Add(sum, i);
			}
			return false;
		}
	}
}
