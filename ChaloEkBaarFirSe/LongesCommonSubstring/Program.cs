using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongesCommonSubstring
{
	class Program
	{
		static void Main(string[] args)
		{
			var res = LCSs("passport", "ppsspt");
			Console.WriteLine(res);

			var res2 = LCSsBottomsUp("passport", "ppsspt");
			Console.WriteLine(res2);
			Console.ReadKey();
		}

		public static int LCSs(string s1, string s2)
		{
			return LCSsHelper(s1, s2, 0, 0, 0);		
		}
		public static int LCSsHelper(string s1, string s2, int s1Index, int s2Index, int count)
		{
			if (s1Index == s1.Length || s2Index == s2.Length)
				return count;
			if (s1[s1Index] == s2[s2Index])
			{
				count =  LCSsHelper(s1, s2, s1Index + 1, s2Index + 1, count + 1);
			}
			int c1 = LCSsHelper(s1, s2, s1Index + 1, s2Index, 0);
			int c2 = LCSsHelper(s1, s2, s1Index, s2Index + 1, 0);
			return Math.Max(count, Math.Max(c1, c2));		
		}

		public static int LCSsBottomsUp(string s1, string s2)
		{
			int[,] dp = new int[s1.Length + 1, s2.Length+1];

			int len = 0;
			int row = 0;
			int col = 0;
			for (int i = 1; i <= s1.Length; i++)
				for (int j = 1; j <= s2.Length; j++)
				{
					if (s1[i-1] == s2[j-1])
					{
						dp[i, j] = 1 + dp[i - 1, j - 1];
						if (len < dp[i, j])
						{
							len = dp[i, j];
							row = i;
							col = j;
						}
					}
				}
			StringBuilder sb = new StringBuilder();
			while (dp[row, col] != 0)
			{
				sb.Insert(0, s1[row - 1]);
				row--;
				col--;
			}
			Console.WriteLine(sb.ToString());
			return len;
		}


	}
}
