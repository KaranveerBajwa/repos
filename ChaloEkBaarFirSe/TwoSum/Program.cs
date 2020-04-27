using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2, 7, 11, 15 };
			var result = PairSum(arr, 22);

		}

		public static int[] PairSum(int[] arr, int target)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			int[] result = { -1, -1 };
			for (int i = 0; i < arr.Length; i++)
			{
				int diff = target - arr[i];
				if (dict.ContainsKey(diff))
				{
					result[0] = dict[target - arr[i]];
					result[1] = i;
					return result;
					}
				else
					dict.Add(arr[i], i);			
			}
			return result;


		}
	}
}
