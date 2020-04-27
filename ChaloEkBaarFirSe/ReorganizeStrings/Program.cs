using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReorganizeStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string S = "abbabbaaab";
			var res = ReorganizeStrings(S);
		}

		public static string ReorganizeStrings(string S)
		{
			Dictionary<char, int> dict = new Dictionary<char, int>();
			StringBuilder sb = new StringBuilder();
			foreach (char c in S)
			{
				if (!dict.ContainsKey(c))
					dict.Add(c, 0);
				dict[c] = dict[c] + 1;
				if (dict[c] > (S.Length + 1) / 2)
					return sb.ToString();
			}
			MaxHeap mh = new MaxHeap(dict.Count);

			foreach (var kvp in dict)
			{
				
				mh.Insert(new MultiChar(kvp.Key, kvp.Value));
			}

			while (mh.Count() >= 2)
			{
				MultiChar mc1 = mh.GetTop();
				MultiChar mc2 = mh.GetTop();
				if (sb.Length == 0 || sb[sb.Length -1] != mc1.Letter)
					{
						sb.Append(mc1.Letter);
						sb.Append(mc2.Letter);
					}
				else
					{
						sb.Append(mc2.Letter);
						sb.Append(mc1.Letter);
					}
				if (--mc1.Count > 0)
					mh.Insert(mc1);
				if (--mc2.Count > 0)
					mh.Insert(mc2);
			}
			if(mh.Count() > 0)
				sb.Append(mh.GetTop().Letter);
			return sb.ToString();
			}

		}

		public class MultiChar
		{
			public int Count { get; set; }
			public char Letter { get; set; }
			public MultiChar(char ch, int num)
			{
				Letter = ch;
				Count = num;
			}
		}

		public class MaxHeap
		{
			MultiChar[] arr;
			int N;
			public MaxHeap(int size)
			{
				arr = new MultiChar[size + 1];
				N = 0;
			}
			public void Insert(MultiChar ch)
			{
				arr[++N] = ch;
				Swim(N);
			}
			public MultiChar GetTop()
			{
				MultiChar mc = arr[1];
				Swap(arr, 1, N);
				N = N - 1;
				Sink(1);
				return mc;
			}
			public int Count()
			{
				return N;
			}
			public void Swim(int k)
			{
				while (k > 1 && arr[k].Count > arr[k/2].Count)
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
					if (j < N && arr[j + 1].Count > arr[j].Count)
						j = j + 1;
					if (arr[k].Count > arr[j].Count)
						break;
					Swap(arr, k, j);
					k = j;
				}
			}

			void Swap(MultiChar[] arr, int i, int j)
			{
				var temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
		}
	}

 
 