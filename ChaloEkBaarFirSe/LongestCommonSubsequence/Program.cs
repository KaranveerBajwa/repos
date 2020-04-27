using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "abdca";
			string s2 = "cbda";
			int res = LCSq(s1, s2);
			int res4 = LCSqBottomsUp(s1, s2);
			Console.WriteLine(res);
			Console.WriteLine();

			Console.WriteLine(res4);
			s1 = "passport";
			s2 = "ppsspt";
			int res2 = LCSq(s1, s2);
			Console.WriteLine(res2);
			int res5 = LCSqBottomsUp(s1, s2);
			Console.WriteLine(res5);
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
			if (s1[s1Index] == s2[s2Index])
				return 1 + LCSqHelper(s1, s2, s1Index + 1, s2Index + 1);
			return Math.Max(LCSqHelper(s1, s2, s1Index + 1, s2Index), LCSqHelper(s1, s2, s1Index, s2Index + 1));
		}

		static int LCSqBottomsUp(string s1, string s2)
		{
			int[,] dp = new int[s1.Length + 1, s2.Length + 1];

			for (int i = 1; i <= s1.Length; i++)
				for (int j = 1; j <= s2.Length; j++)
				{
					if (s1[i - 1] == s2[j - 1])
						dp[i, j] = 1 + dp[i - 1, j - 1];
					else
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
				}
			int index = dp[s1.Length, s2.Length];
			char[] lcs = new char[index];
			StringBuilder sb = new StringBuilder();
			int k = s1.Length;
			int l = s2.Length;
			while (k > 0 && l > 0)
			{
				if (s1[k-1] == s2[l-1])
				{
					lcs[index - 1] = s1[k - 1];
					sb.Insert(0, s1[k - 1]);
					k--;
					l--;
					index--;
				}
				else if (dp[k - 1, l] > dp[k, l - 1])
					k--;
				else
					l--;
			}
			Console.WriteLine(new String(lcs));
			return dp[s1.Length, s2.Length];
		}
	}
}
 