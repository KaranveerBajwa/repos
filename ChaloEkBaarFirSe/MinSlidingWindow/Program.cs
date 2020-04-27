using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSlidingWindow
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "ADOBECODEBANC".ToLower();
			string t = "ABC".ToLower();
			var res = MinWindows(s, t);
		}

		public static string MinWindows(string s, string t)
		{
			if (s == null || t == null)
				return null;
			HashSet<char> hs = new HashSet<char>(t);
			Dictionary<char, int> dict = new Dictionary<char, int>();
			int l = 0;
			int r = 0;
			string minSubstring = s;
			while (r < s.Length)
			{
				char c = s[r];
				if (dict.ContainsKey(c))
						dict[c] = dict[c] + 1;
				else
					if (hs.Contains(c))
						dict.Add(c, 1);

				if (dict.Count == hs.Count)
				{
					while (dict.Count == hs.Count)
					{
						char cL = s[l];
						if (dict.ContainsKey(cL))
						{
							dict[cL] = dict[cL] - 1;
							if (dict[cL] == 0)
							{
								int len = r + 1 - l;
								if (len < minSubstring.Length)
									minSubstring = s.Substring(l, len);
								dict.Remove(cL);
							}
						}
						l++;
					}
		
				}
				r++;
			}
			return minSubstring;
		}
	}
}
