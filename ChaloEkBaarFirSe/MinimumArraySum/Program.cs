using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumArraySum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2, 3, 1, 2, 4, 3 };
			int count =MinimumArraySum(arr, 7);
			Console.WriteLine(count);
			Console.ReadKey();
		}

		public static int MinimumArraySum(int[] arr, int target)
		{
			int left = 0;
			int right = 1;
			int minLength = Int32.MaxValue;
			int sum = arr[0];
			while (right < arr.Length)
			{
				if (left > right)
				{
					right = left;
					sum = arr[left];
				}
				sum = sum + arr[right];
				if (sum > target)
				{
					sum = sum - arr[left];
					left++;
				}
				else if (sum < target)
					right++;
				else
				{
					int length = right - left + 1;
					minLength = Math.Min(minLength, length);
					left++;
				}			
			}
			return minLength;
		}
	}
}
