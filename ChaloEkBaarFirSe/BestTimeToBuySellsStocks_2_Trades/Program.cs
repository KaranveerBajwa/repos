using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuySellsStocks_2_Trades
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] prices = { 3,2,6,5,0,3};
			int maxProfit = MaxProfit(prices);
			Console.WriteLine(maxProfit);
			Console.Read();
		}

		public static  int MaxProfit(int[] prices)
		{
			if (prices == null || prices.Length == 0)
				return 0;
			int[] bestTradeFromI = new int[prices.Length];
			int[] bestTradeToI = new int[prices.Length];

			int min = Int32.MaxValue;
			int max = Int32.MinValue;
			int maxTrade = 0;
			int maxDiff = 0;
			// create bestTradesFromI
			for (int i = 0; i < prices.Length; i++)
			{
				min = Math.Min(min, prices[i]);
				maxTrade = Math.Max(maxTrade, prices[i] - min);
				bestTradeToI[i] = maxTrade;
			}
			maxDiff = 0;
			for (int i = prices.Length -1; i >= 0; i--)
			{
				max = Math.Max(max, prices[i]);
				maxDiff = Math.Max(maxDiff, max - prices[i]);
				bestTradeFromI[i] = maxDiff;
			}
			for (int i = 0; i < prices.Length; i++)
			{
				int maxFrom = i < prices.Length -1 ? bestTradeFromI[i+1] : 0;
				maxTrade = Math.Max(maxTrade, bestTradeToI[i] + maxFrom);
			}
			return maxTrade;

		}
	}
}
