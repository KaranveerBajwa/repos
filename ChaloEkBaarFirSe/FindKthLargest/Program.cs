using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindKthLargest
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 5, 2, 4, 6, 8 };
			var result = GetKthLargest(nums, 3);
		}

		public static int GetKthLargest(int[] nums, int k)
		{
			if (k < 0 || k > nums.Length)
				throw new Exception("Out of bound");
			int j = nums.Length - k;
			int index = GetKthLargestHelper(nums, j, 0, nums.Length - 1);
			return nums[index];
		}

		static int GetKthLargestHelper(int[] nums, int j, int left, int right)
		{
			if (left > right)
				return -1;
			Random rnd = new Random();
			int pivotLoc = rnd.Next(left, right);
			int pivotIndex = Partition(nums, left, right, pivotLoc);
			if (pivotIndex < j)
				GetKthLargestHelper(nums, j, pivotIndex + 1, right);
			else if (pivotIndex > j)
				GetKthLargestHelper(nums, j, left, pivotIndex - 1);
			else
				return pivotIndex;
			return -1;		
		}
		static int Partition(int[] nums, int left, int right, int pivotLoc)
		{
			Swap(nums, left, pivotLoc);
			int start = left ;
			left = left+1 ;
			while (left <= right)
			{
				if (nums[left] >nums[start])
				{
					Swap(nums, left, right);
					right--;
				}
				else
				{
					left++;
				}
			}
			Swap(nums, start, left-1);
			return left-1;
		}

		static void Swap(int[] nums, int i, int j)
		{
			int temp = nums[i];
			nums[i] = nums[j];
			nums[j] = temp;
		}




	}
}
