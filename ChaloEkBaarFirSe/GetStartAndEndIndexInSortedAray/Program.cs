using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartAndEndIndexInSortedAray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 3, 3, 5, 7, 8, 9, 9, 9, 10 };
			int target = 9;
			var res = GetRange(arr, target);
		}

		public static int[] GetRange(int[] arr, int target)
		{
			int[] result = new int[2];
			result[0] = GetLeftIndex(arr, target);
			result[1] = GetRightIndex(arr, target);
			return result;
		}

		static int GetLeftIndex(int[] arr, int target)
		{
			int left = 0;
			int right = arr.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if ((mid == 0 || arr[mid - 1] < target) && arr[mid] == target)
					return mid;
				else if (target > arr[mid])
					left = mid + 1;
				else
					right = mid - 1;
			}
			return -1;
		}

		static int GetRightIndex(int[] arr, int target)
		{
			int left = 0;
			int right = arr.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if ((mid == arr.Length - 1 || target < arr[mid + 1]) && arr[mid] == target)
					return mid;
				else if (target < arr[mid])
					right = mid - 1;
				else
					left = mid + 1;
			}
			return - 1;

		
		}
	
	}
} 
