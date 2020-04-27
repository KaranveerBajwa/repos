using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFirstOccurenceOfTargetWithDuplicates
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2, 3, 4, 4, 4, 5, 6 };
			int res = FirstOccurance(arr, 4);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static int FirstOccurance(int[] arr, int target)
		{
			int start = 0;
			int end = arr.Length - 1;
			while (start <= end)
			{
				int mid = start + (end - start) / 2;
				if (target < arr[mid] || (arr[mid] == target && mid >0 && arr[mid-1] == target))
					end = mid - 1;
				else if (target > arr[mid])
					start = mid + 1;
				else
					return mid;			
			}
			return -1;
		}
	}
}
