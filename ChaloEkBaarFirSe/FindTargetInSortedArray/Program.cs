using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTargetInSortedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 4, 7, 8, 9 };
			int res = BinarySearch(arr, 10 );
			Console.WriteLine(res);
			Console.ReadKey();
		}

		static int BinarySearch(int[] nums, int target)
		{
			if(nums == null || nums.Length ==0)
				return -1;
			int start = 0;
			int end = nums.Length - 1;
			while (start <= end)
			{
				int mid = start + (end - start) / 2;
				if (nums[mid] > target)
				{
					end = mid - 1;
				}
				else if (nums[mid] < target)
				{
					start = mid + 1;
				}
				else
					return mid;
			}
			return -1;
		}
	}
}
