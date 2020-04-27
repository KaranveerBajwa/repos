using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC208_ImplementTrie
{
	class Program
	{
		static void Main(string[] args)
		{
			Trie trie = new Trie();

			trie.Insert("apple");
			Console.WriteLine(trie.Search("apple"));   // returns true
			Console.WriteLine(trie.Search("app"));     // returns false
			Console.WriteLine(trie.StartsWith("app")); // returns true
			trie.Insert("app");
			Console.WriteLine(trie.Search("app"));     // returns true
		}
	}
}
