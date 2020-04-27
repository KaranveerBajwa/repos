using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { -2, -3, 4, -1, -2, 1, 5, -1 };
			int res = MaxSubarraySum.MaxSum(arr);
			var ress = MaxSubarraySum.MaxSumSubArray(arr);
			int[] arr1 = { 1,2,3,5,2};
			SubArrayWithGivenSum.SubArrayWithXSum(arr1, 8);
		}
	}
}
