using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDecreasingArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = {  3,1};
			var isPossible = CheckPossiblity(nums);
		}
		public  static bool CheckPossiblity(int[] nums)
		{
			int? idx = null;
			if (nums == null || nums.Length == 0)
				return true;
			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i] > nums[i + 1])
				{
					if (idx == null)
						idx = 1;
					else
						return false;
				}
			}
			if (idx == null)
				return true;
			int index = idx.Value;
			if (index == 0)
				return true;
			if (index == nums.Length - 2)
				return true;
			if ((index + 2 >= nums.Length) ||nums[index] <= nums[index + 2])
				return true;
			if ( (index+1 >= nums.Length) ||nums[index - 1] <= nums[index + 1])
				return true;

			return false;
		}

	}
}
