using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "The quick brown fox jumped over the lazy dog";
			var res =  ToGoatLatin(s);
			Console.WriteLine(res);
			Console.ReadKey();
		
		}

		public static string ToGoatLatin(string S)
		{
			if (string.IsNullOrEmpty(S))
				return S;
			string[] words = S.Split(' ');
			string vowel = "aeiouAEIOU";
			string toAppend = "ma";
			HashSet<char> vowels = new HashSet<char>(vowel);
			for (int i = 0; i < words.Length; i++)
			{
				if (vowels.Contains(words[i][0]))
				{
					words[i] = words[i] + toAppend;
				}
				else
				{
					words[i] = words[i].Substring(1, words[i].Length - 1) + words[i][0] + toAppend;
				}
				string a = "";
				for (int j = 0; j <= i; j++)
				{
					a += "a";
				}
				words[i] = words[i] + a;
			}

			return string.Join(" ", words);
		}

	}
}
