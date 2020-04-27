using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>() ;
			dict.Add('a', new List<string>( ));
			dict.Add('e', new List<string>());
			dict.Add('s', new List<string>());
			dict.Add('k', new List<string>());
			dict.Add('t', new List<string>());
			dict['a'].Add("apples");
			dict['a'].Add("Africs");
			dict['e'].Add("eggs");
			dict['s'].Add("snacks");
			dict['k'].Add("karat");
			dict['t'].Add("tuna");
//			string currentWord = "apple";
			char lastCharacter = 'e';
			var t = dict['e'];
			foreach (var s in dict[lastCharacter])
			{
				Console.WriteLine(s);
			}
			Console.ReadKey();
		}

	}
}
