using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangingProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] coins = { 1, 2, 5 };
			CoinChanging(coins, 5);
			Console.ReadKey();
		}

		public static void CoinChanging(int[] coins, int target)
		{
			if (coins == null || coins.Length == 0 || target < 0)
				return;
			List<List<int>> list = new List<List<int>>();
			List<int> buffer = new List<int>();
			CoinChangingHelper(coins,target, 0,0,buffer, list);

		}

		public static void CoinChangingHelper(int[] coins, int target, int sum, int startIndex, List<int> buffer, List<List<int>> list)
		{
			if (sum > target)
				return;
			if (sum == target)
			{
				foreach (int i in buffer)
					Console.Write(i + ",");
				Console.WriteLine();
				return;
			}
			for (int i = startIndex; i < coins.Length; i++)
			{
				buffer.Add(coins[i]);
				CoinChangingHelper(coins, target, sum+ coins[i], i,buffer,  list);
				buffer.RemoveAt(buffer.Count - 1);
			}
		}


	}
}
