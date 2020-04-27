using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSubsetSumDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "abdca";
			string s2 = "cdba";
			int res = LCSq(s1, s2);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static int LCSq(string s1, string s2)
		{
			return LCSqHelper(s1, s2, 0, 0);
		}

		static int LCSqHelper(string s1, string s2, int s1Index, int s2Index)
		{
			if (s1Index == s1.Length || s2Index == s2.Length)
				return 0;
			return Math.Max(LCSqHelper(s1, s2, s1Index + 1, s2Index), LCSqHelper(s1, s2, s1Index, s2Index));
		}
	}
}
