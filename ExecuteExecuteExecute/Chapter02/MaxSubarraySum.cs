using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
	public static class MaxSubarraySum
	{

		public static int MaxSum(int[] arr)
		{
			int maxSum = Int32.MinValue;
			int curSum = arr[0];
			int start = 0;
			int end = 0;
			int maxStart = 0;
			int maxEnd = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				int iSum = curSum + arr[i];
				if (arr[i] >= iSum)
				{
					start = i;
					end = i;
				}
				else
				{
					end = i;
				}
				//curSum = Math.Max(arr[i], curSum + arr[i]);

				if (curSum > maxSum)
				{
					maxStart = start;
					maxEnd = end;
					maxSum = curSum;
				}
				maxSum = Math.Max(maxSum, curSum);
			}
			return maxSum;
		}

		public static int[] MaxSumSubArray(int[] arr)
		{
			int maxSum = arr[0];
			int curSum = arr[0];
			int start = 0;
			int end = 0;
			int maxStart = 0;
			int maxEnd = 0;
			for (int i = 1; i < arr.Length; i++)
			{
				int iSum = curSum + arr[i];
				if (arr[i] >= iSum)
				{
					start = i;
					end = i;
					curSum = arr[i];
				}
				else
				{
					curSum = iSum;
					end++;
				}
				//curSum = Math.Max(arr[i], curSum + arr[i]);

				if (curSum > maxSum)
				{
					maxStart = start;
					maxEnd = end;
					maxSum = curSum;
				}
				//maxSum = Math.Max(maxSum, curSum);
			}
			int length = maxEnd - maxStart + 1;
			int[] resArr = new int[length];
			for (int i = 0; i < length; i++)
			{
				resArr[i] = arr[maxStart++];
			}
			return resArr;

		}

	}

}
