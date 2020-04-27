using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSearchWord
{
	class Program
	{
		static void Main(string[] args)
		{
			WordDictionary t = new WordDictionary();
			t.AddWord("bad");
			t.AddWord("dad");
			t.AddWord("mad");
			t.AddWord("search");
			var res33 = t.Search(".a");
//			t.AddWord("pad");
			Console.WriteLine($" pad: {t.Search("bad")}");
			Console.WriteLine($".ad: {t.Search(".ad")} ");
			Console.WriteLine($"pad: {t.Search("pad")} ");
			Console.WriteLine(t.Search("b.."));
			Console.WriteLine(t.Search("..d"));
			var res2 = t.Search(null);
				var res = t.Search("he.llo");
		}
	}
}
