using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			ISavable catalog = new Catalog();
			catalog.Save();
			Console.ReadKey();

			//string[] toys = { "elmo", "elsa", "legos", "drone", "tablet", "warcraft" };
			////numQuotes = 6
			//string[] quotes = {
			//				"Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
			//				"The new Elmo dolls are super high quality",
			//				"Expect the Elsa dolls to be very popular this year, Elsa!",
			//				"Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
			//				"For parents of older kids, look into buying them a drone",
			//				"Warcraft is slowly rising in popularity ahead of the holiday season"
			//};
			//Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
			//foreach (string s in quotes)
			//{
			//	//	string[] substrings = Regex.Split(input, pattern);
			//	string[] temp = System.Text.RegularExpressions.Regex.Split(s.ToLower(), @"\W+");
			//	List.re
			//	HashSet<string> dict01 = new HashSet<string>();
			//	foreach (string v in temp)
			//	{
			//		if (toys.Contains(v))
			//		{
			//			if (!dict.ContainsKey(v))
			//			{
			//				dict.Add(v, new int[2]);
			//			}
			//			dict[v][0]++;
			//			dict01.Add(v);
			//		}
			//	}
			//	foreach (var kvp in dict01)
			//	{
			//		if (dict.ContainsKey(kvp))
			//			dict[kvp][1]++;
			//	}
			//}
		}
		public class MinHeap
		{
			QuoteInfo[] arr;
			int N;
			public MinHeap(int size)
			{
				arr = new QuoteInfo[size + 1];
				N = 0;
			}
			public void Insert(QuoteInfo val)
			{
				if (N < arr.Length)
					arr[++N] = val;
				else if (arr[1].occurences < val.occurences || (arr[1].occurences == val.occurences && arr[1].quoteCount < val.quoteCount))
				{
					Delete();
				}
				Swim(N);
			}
			public QuoteInfo Delete()
			{
				var temp = arr[1];
				Swap(arr, 1, N);
				N = N - 1;
				Sink(1);
				return temp;
			}
			public int Count()
			{
				return N;
			}
			public void Swim(int k)
			{
				while (k > 1 && arr[k / 2].occurences > arr[k].occurences)
				{
					Swap(arr, k, k / 2);
					k = k / 2;
				}
			}
			public void Sink(int k)
			{
				while (k * 2 <= N)
				{
					int j = k * 2;
					if (j < N && arr[j + 1].occurences < arr[j].occurences)
						j = j + 1;
					if (arr[j].occurences < arr[k].occurences)
						Swap(arr, j, k);
					else
						break;
					k = j;
				}
			}
			public void Swap(QuoteInfo[] arr, int i, int j)
			{
				var temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}

		}

		public class QuoteInfo {
			public string quote;
			public int occurences;
			public int quoteCount;
			public QuoteInfo(string s, int count, int countInquotes)
			{
				quote = s;
				occurences = count;
				quoteCount = countInquotes;
			}
		}
	}
}

