using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingElementInSortedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 4, 7, 9, 10 };
			int k = 3;
			int res = MissingElement(nums, k);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static int MissingElement(int[] nums, int k)
		{
			int left = 0;
			int right = nums.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (nums[mid] < nums[0] + mid + k)
					left = mid + 1;
				else
					right = mid - 1;			
			}
			return nums[0] + right + k;

		}
	}
}
