using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "abcda";
			var res = ValidPalindrome(s);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static bool ValidPalindrome(string s)
		{
			if (s == null || s.Length == 0)
				return true;
			int left = 0;
			int right = s.Length - 1;
			while (left <= right)
			{
				if (s[left] == s[right])
				{
					left++;
					right--;
				}
				else
				{
					if (IsPalindrome(s, left + 1, right))
						return true;
					else if (IsPalindrome(s, left, right - 1))
						return true;
					else
						return false;
				}
			}
			return true;
		}
		static bool IsPalindrome(string s, int left, int right)
		{
			while (left <= right)
			{
				if (!(s[left] == s[right]))
					return false;
				left++;
				right--;
			}
			return true;
		}


		}
	}
