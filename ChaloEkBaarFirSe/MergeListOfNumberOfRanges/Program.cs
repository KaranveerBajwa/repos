using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeListOfNumberOfRanges
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 0, 1, 2, 5, 7, 8, 9, 9, 10, 11, 15 };
			List<string> list = MergeListToRanges(nums);
			foreach (var i in list)
			{
				Console.WriteLine(i);

			}
			Console.ReadKey();
		}

		public static List<string> MergeListToRanges(int[] nums)
		{
			List<string> list = new List<string>();
			if (nums == null || nums.Length == 0)
				return list;
			int start = nums[0];
			int end = nums[0];
			for (int i  = 1; i < nums.Length; i++)
			{
				if (nums[i - 1] + 1 == nums[i])
					end = nums[i];
				else
				{
					if (start == end)
						list.Add($"{start}");
					else
						list.Add($"{start} - {end}");
					start = nums[i];
					end = nums[i];
				}		
			}
			if (start == end)
				list.Add($"{start}");
			else
				list.Add($"{start} - {end}");
			return list;

		
		}
	}
}
