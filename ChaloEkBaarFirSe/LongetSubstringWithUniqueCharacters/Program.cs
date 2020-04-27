using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongetSubstringWithUniqueCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "whatwhywhere";
			string result = GetLongestUniqueString(s);
		}

		public static string GetLongestUniqueString(string s)
		{
			int left = 0; int right = 0; 
			int maxStart = 0; int maxEnd = 0; int maxLength = 1;
			HashSet<char> set = new HashSet<char>();
			set.Add(s[0]);
			while (right < s.Length-1)
			{
				right++;
				if (!set.Contains(s[right]))
				{
					set.Add(s[right]);					
				}
				else
				{
					char ch = s[right];
					while (set.Contains(ch))
					{
						set.Remove(s[left++]);
					}
					set.Add(ch);				
				}
				int length = right - left + 1;
				if (maxLength < length)
				{
					maxLength = length;
					maxStart = left;
					maxEnd = right;
				}
			
			}

			return s.Substring(maxStart, maxEnd-maxStart + 1);
			}

		}
	
	}

 