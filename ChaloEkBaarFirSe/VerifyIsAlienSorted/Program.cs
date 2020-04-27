using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyIsAlienSorted
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = { "hello", "leetcode" };
			string order = "hlabcdefgijkmnopqrstuvwxyz";
			var res = IsAlienSorted(words, order);
			Console.WriteLine(res);

			words = new string[]{ "word", "world", "row"};
			order = "worldabcefghijkmnpqstuvxyz";
			var res2 = IsAlienSorted(words, order);
			Console.WriteLine(res2);

			Console.Read();

		}

		public static bool IsAlienSorted(string[] words, string order)
		{
			// create dictionary of order
			// compare neighboring words 
			if (words == null || words.Length == 1)
				return true;
			Dictionary<char, int> dict = new Dictionary<char, int>();
			for (int i = 0; i < order.Length; i++)
			{
				dict.Add(order[i], i);
			}
			for (int i = 1; i < words.Length; i++)
			{
				if (!IsCorrectOrder(words[i - 1], words[i], dict))
					return false;
			}
			return true;
		}

		static bool IsCorrectOrder(string s1, string s2, Dictionary<char, int> dict)
		{
			for (int i = 0; i < s1.Length; i++)
			{
				int c1 = dict[s1[i]];
				int c2 = i < s2.Length ? dict[s2[i]] : c1 - 1;
				if (c1 > c2)
					return false;
				if (c1 < c2)
					return true;
			}
			return true;
		}
	}
}
