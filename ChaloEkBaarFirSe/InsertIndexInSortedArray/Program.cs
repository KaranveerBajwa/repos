using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertIndexInSortedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 4,4, 5, 6, 8 };
			int res = InsertIndex(nums, 3);
			Console.WriteLine(res);
			Console.WriteLine(InsertIndex(nums, 0));
			Console.WriteLine(InsertIndex(nums, 4));
			Console.ReadKey();
		}

		public static int InsertIndex(int[] nums, int target)
		{
			int left = 0;
			int right = nums.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (target < nums[mid])
				{
					if (mid == 0 || nums[mid - 1] < target)
						return mid;
					right = mid - 1; ;
				}
				else if (target > nums[mid])
				{
					if (mid == nums.Length - 1)
						return mid;
					left = mid + 1;
				}
				else
					return mid;
			}
			return -1;
		}
	}
}
