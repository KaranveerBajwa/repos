using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayMaxSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { -2, -3, 4, -1, -2, 1, 5, -1 };
			var resultSubarray = SubArrayMaxSum(arr);
		}

		static int[]  SubArrayMaxSum(int[] arr)
		{
			int maxSum = Int32.MinValue;
			int sum = arr[0];
			int start = 0;
			int end = 0;
			int maxStart = 0;
			int maxEnd = 0;
			for (int i = 1; i < arr.Length; i++)
			{
				sum = sum + arr[i];
				if (sum < arr[i])
				{
					sum = arr[i];
					start = i;
					end = i;
				}
				else 
					end = i;
				if (sum > maxSum)
				{
					maxStart = start;
					maxEnd = end;
					maxSum = sum;
				}
			}
			int[] subArr = new int[maxEnd - maxStart + 1];
			int j = 0;
			for (int i = maxStart; i <= maxEnd; i++,j++)
			{

				subArr[j] = arr[i];
			}
			return subArr;
		}
	}
}
