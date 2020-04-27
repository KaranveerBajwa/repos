using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithNoRepeatingCharacter
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "abccde";
			Console.WriteLine(FindLength(str));
			Console.ReadKey();
		}

		public static int FindLength(string str)
		{
			int start = 0; int end = 0; int maxLength = 0;
			int left = 0;
			HashSet<char> set = new HashSet<char>();
			for (int right = 0; right < str.Length; right++)
			{
				if (set.Contains(str[right]))
				{
					int curLength = right - left;
					if (curLength > maxLength)
						maxLength = curLength;
					left++;
				}
				else
					set.Add(str[right]);
			}
			return maxLength;
		}
	}
}
