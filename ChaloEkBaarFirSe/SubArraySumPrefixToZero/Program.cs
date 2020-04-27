using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySumPrefixToZero
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2,4,-2,1,-3,5,-3 };
			var res = SubArrayWithSumToZero(arr);
			var result = SubArrayWithSumToTarget(arr, 5);
		}

		public static int[] SubArrayWithSumToZero(int[] arr)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(0, -1);
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				if (dict.ContainsKey(sum))
				{
					int left = dict[sum] + 1;
					return GetArray(arr, left, i);
				}
				else
					dict.Add(sum, i);
			}
				return new int[] { };
		}
		public static int[] SubArrayWithSumToTarget(int[] arr, int target)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(0, -1);
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				if (dict.ContainsKey(sum - target))
				{
					int left = dict[sum-target] + 1;
					return GetArray(arr, left, i);
				}
				else
					dict.Add(sum, i);
			}
			return new int[] { };
		}
		static int[] GetArray(int[] arr, int i, int j)
		{
			int[] result = new int[j - i + 1];
			int l = 0;
			for (int k = i; k <= j; k++,l++)
			{
				result[l] = arr[k];
			}
			return result;
		}
	}
}
