using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
	public static class SubArrayWithGivenSum
	{
		public static int[] SubArrayWithXSum(int[] arr, int x)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			int start = 0;
			int end = 0;
			int sum = arr[0];
			dict.Add(sum, 0);
			for (int i = 1; i < arr.Length; i++)
			{
				sum = sum + arr[i];
				if (sum == x)
				{
					end = i;
					break;
				}
				if (dict.ContainsKey(sum - x))
				{
					start =  dict[sum - x] + 1;
					end = i;
					break;
				}
				else
					dict.Add(sum, i);

			}
			int[] res = new int[end - start + 1];
			for (int i = 0; i < res.Length; i++)
			{
				res[i] = arr[start++];
			}
			return res;
		}

	}
}
