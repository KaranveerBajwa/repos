using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInRotatedSortedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 5, 7, 8, 1, 2, 4 };
			int num = SmallestElementIndex(nums);
			Console.WriteLine(num);
			Console.ReadKey();
		}

		public static int SmallestElementIndex(int[] nums)
		{
			int start = 0;
			int end = nums.Length - 1;
			while (start <= end)
			{
				int mid = start + (end - start) / 2;
				if (nums[start] <= nums[end])
				{
					if (mid == 0 || nums[mid] < nums[mid - 1])
						return mid;
					else
						end = mid - 1;
				}
				else
					start = mid + 1;
			}
			return -1;
		}
	}
}
