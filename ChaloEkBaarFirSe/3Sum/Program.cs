using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { -1, 0, 1, 2, -1, -4 };
			var result = ThreeSum(nums);
		}

		public static List<List<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);
			List<List<int>> list = new List<List<int>>();
			for (int i = 0; i < nums.Length - 2; i++)
			{
				int left = 0;
				int right = nums.Length - 1;
				int target = -1 * nums[i];
				while (left < right)
				{
					int val = nums[left] + nums[right];
					if (val == target)
					{
						int[] arr = { nums[i], nums[left], nums[right] };
						list.Add(arr.ToList());
						break;

					}
					else if (val > target)
					{
						right--;
					}
					else
						left++;
				}
			}
			return list;
		}
	}
}

