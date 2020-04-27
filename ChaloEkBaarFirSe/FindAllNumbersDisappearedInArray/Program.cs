using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllNumbersDisappearedInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1,1 };
			var res = FindDisappearedNumbers(nums);
		}

		
		public static IList<int> FindDisappearedNumbers(int[] nums)
		{
			int[] arr = new int[nums.Length + 1];
			for (int i = 0; i < nums.Length; i++)
			{
				arr[nums[i]] = arr[nums[i]] + 1;
			}
			IList<int> list = new List<int>();
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == 0)
					list.Add(i);
			}
			return list;		
		}
	}
}
