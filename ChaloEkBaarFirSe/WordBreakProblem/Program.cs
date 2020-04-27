using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBreakProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "ilovemangotango";
			HashSet<string> dict = new HashSet<string>();
			dict.Add("i");
			dict.Add("love");
			dict.Add("mango");
			dict.Add("tango");
			var res = WordBreak(s, dict);
		}

		public static List<string> WordBreak(string s, HashSet<string> dict)
		{
			List<string> res = new List<string>();
			if (s == null || s.Length == 0)
			{
				return res;
			}
			bool[] memoNotPossible = new bool[s.Length];
			if (WordBreakHelper(s, 0, res, memoNotPossible, dict))
				return res;
			else
				return new List<string>();
		}
		static bool WordBreakHelper(string s, int curIndex, List<string> res,bool[] memoNotPossible, HashSet<string> dict )
		{
			if (curIndex == s.Length)
				return true;
			if (memoNotPossible[curIndex])
				return false;
			for (int i = curIndex; i < s.Length; i++)
			{
				string word = s.Substring(curIndex, i - curIndex + 1);
				if (dict.Contains(word))
				{
					res.Add(word);
					if (WordBreakHelper(s, i + 1, res, memoNotPossible, dict))
						return true;
					else
					{
						res.RemoveAt(res.Count - 1);
						memoNotPossible[i + 1] = true;
					}
				}
			}
			return false;		
		}


	}
}
