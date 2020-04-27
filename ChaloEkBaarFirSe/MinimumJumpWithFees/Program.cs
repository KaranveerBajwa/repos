using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumJumpWithFees
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] fees = {1,2,5,2,1,2};
			var res2 = FindMinBottomsUpDP(fees);
			var res = FindMinFee(fees);
		}

		static int FindMinFee(int[] fees)
		{
			var res = FindMinFeeRecursive(fees, 0);
			// var res2 = FindMinFeeRecursive2(fees, 0);
			return res;
		}

		static int FindMinFeeRecursive(int[] fees, int curIndex)
		{
			if (curIndex >= fees.Length)
				return 0;
			int take1Step = fees[curIndex] + FindMinFeeRecursive(fees, curIndex + 1);
			int take2Step = fees[curIndex] + FindMinFeeRecursive(fees, curIndex + 2);
			int take3Step = fees[curIndex] + FindMinFeeRecursive(fees, curIndex + 3);
			return Math.Min(take1Step, Math.Min(take2Step, take3Step));
		}

		static int FindMinBottomsUpDP(int[] fees)
		{
			int[] dp = new int[fees.Length + 1];
			dp[0] = 0;
			dp[1] = fees[0];
			dp[2] = fees[0];
		 
			for (int i = 3; i <= fees.Length; i++)
			{
				int take1Step = fees[i-1] + dp[i - 1];
				int take2Step = i -2 >= 0 ?fees[i-2] + dp[i - 2]: 0;
				int take3Step = i - 3 >= 0 ?fees[i - 3] + dp[i - 3]: 0;
				dp[i] = Math.Min(take1Step, Math.Min(take2Step, take3Step));
			}
			return dp[fees.Length];
		}
	
	}
}
