using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithKMostCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "cbebbi";
			int k = 3;
			int res = LengthOfLongestSubstringKDistinct(s, k);
			Console.WriteLine(res);
			Console.ReadKey();
		}
		public static int LengthOfLongestSubstringKDistinct(string s, int k)
		{
			int start = 0;
			int end = 0;
			int left = 0;
			int maxLength = 0;
			Dictionary<char, int> dict = new Dictionary<char, int>();
			for (int right = 0; right < s.Length; right++)
			{
				if (!dict.ContainsKey(s[right]))
					dict.Add(s[right], 0);
				dict[s[right]] = dict[s[right]] + 1;

				while (dict.Count > k)
				{
					dict[s[left]] = dict[s[left]] - 1;
					if (dict[s[left]] == 0)
						dict.Remove(s[left]);
					left++;
				}
				int curLength = right - left + 1;
				if (curLength > maxLength)
				{
					maxLength = curLength;
					start = left;
					end = right;
				}
			}
			Console.WriteLine(s.Substring(start, end - start + 1));
			return maxLength;
		}
		}
	}

