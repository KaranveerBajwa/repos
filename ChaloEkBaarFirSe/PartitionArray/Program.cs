using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
namespace PartitionArray
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] arr = {  1, 2, 3, 4, 0, 5, 0, 0};
			//ArrangeZeros(arr);
			//ArrayHelper.PrintIntArray(arr);
			//Console.ReadKey();

			//int[] arr1 = { 1, 4, 3, 4, 4, 6, 3, 2 };
			//DNP(arr1, 4);
			//ArrayHelper.PrintIntArray(arr1);
			//Console.ReadKey();

			//Colors[] arr2 = { Colors.Red, Colors.Red, Colors.Blue, Colors.Blue, Colors.White, Colors.Red };
			//ArrangeMarbles(arr2);
			//ArrayHelper.PrintArray(arr2);
			//Console.ReadKey();

			int[] arr3 = { 1, 2, -1, 2, -3, 2, -5};
			int res = MaximumSums(arr3);
			var res1 = MaximumSumsIndices(arr3);
			Console.WriteLine(res);
			ArrayHelper.PrintArray(res1);
			Console.ReadKey();
		}

		#region ArrangeZeroes
		public static void ArrangeZeros(int[] arr)
		{
			int p0 = 0;
			for (int pr = 0; pr < arr.Length; pr++)
			{
				if (arr[pr] == 0)
				{
					ArrayHelper.Swap(arr, p0++, pr);
				}
			}
		}
		#endregion

		#region DutchNationalProblem

		public static void DNP(int[] arr, int pivotValue)
		{
			int left = 0;
			int mid = 0;
			int right = arr.Length - 1;
			while (mid <= right)
			{
				if (arr[mid] < pivotValue)
				{
					ArrayHelper.Swap(arr, left++, mid++);
				}
				else if (arr[mid] > pivotValue)
				{
					ArrayHelper.Swap(arr, mid, right--);
				}
				else
					mid++;
			}
		}

		#endregion

		#region ArrangeMarbles
		public enum Colors{ 
			Red =0,
			White =1,
			Blue = 2
		};
		public static void ArrangeMarbles(Colors[] arr)
		{
			int left = 0;
			int mid = 0;
			int right = arr.Length - 1;
			while (mid < right)
			{
				switch (arr[mid])
				{
					case Colors.Red:
						ArrayHelper.Swap<Colors>(arr, left++, mid++);
						break;
					case Colors.White:
						mid++;
						break;
					case Colors.Blue:
						ArrayHelper.Swap(arr, mid, right--);
						break;
					default:
						throw new Exception("Invalid input");
				}
			}
		}

		#endregion

		#region Maximum SubarraySum

		public static int MaximumSums(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return 0;
			int sum = nums[0];
			int maxSum = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				sum = Math.Max(sum + nums[i], nums[i]);
				maxSum = Math.Max(sum, maxSum);
			}
			return maxSum;
		}

		public static int[] MaximumSumsIndices(int[] nums)
		{
			int sum = nums[0];
			int maxSum = nums[0];
			int resStart = 0;
			int resEnd = 0;
			int start = 0;
			int end = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				sum = sum + nums[i];
				if (sum > nums[i])
				{
					end = i;
				}
				else
				{
					sum = nums[i];
					start = i;
					end = i;
				}

				if (sum > maxSum)
				{
					maxSum = sum;
					resStart = start;
					resEnd = end;
				}
			}
			return new int[] { resStart, resEnd };
		
		}
		#endregion
	}
}
