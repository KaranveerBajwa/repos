using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MostCommonWords
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "Bob. hIt, baLl";
 
				string[] banned = { "bob", "hit" };
			var res = MostCommonWord(s, banned);
		}

		public static  string MostCommonWord(string paragraph, string[] banned)
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			HashSet<string> bannedWords = new HashSet<string>(banned);
			string[] words = Regex.Split(paragraph.ToLower(), @"\W");
			foreach (string word in words)
			{
				if (!bannedWords.Contains(word))
				{
					if (!String.IsNullOrEmpty(word))
						{
						if (!dict.ContainsKey(word))
							dict.Add(word, 0);
						dict[word] = dict[word] + 1;
					} 
				}
			}
			string maxWord = "";
			int maxCount = -1;
			foreach (var key in dict.Keys)
			{
				if (dict[key] > maxCount)
				{
					maxWord = key;
					maxCount = dict[key];
				}
			}

			return maxWord;
		}
	}
}
