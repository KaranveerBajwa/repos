using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
	class Program
	{
		static void Main(string[] args)
		{
			TrieWithArray trieArr = new TrieWithArray();
			trieArr.Insert("hello");
			trieArr.Insert("helloworld");
			bool res1 = trieArr.Search("hello");
			bool res2 = trieArr.Search("hh");
			Trie trie = new Trie();
			trie.Insert("hello");
			trie.Insert("helloworld");
			bool res21 = trie.Search("hello");
			bool res22 = trie.Search("hh");
			string[] s = { "leetscode", "leet", "leeds", "leet" };
			var rres = LongestCommonPrefix(s);

		}

		public static string LongestCommonPrefix(string[] strs)
		{
			// build a trie
			// loop trhough tri till it has only single path and is not end of word
			if (strs == null || strs.Count() == 0)
				return string.Empty;
			Trie trie = new Trie();
			foreach (var word in strs)
			{
				trie.Insert(word);
			}
			return trie.GetPrefix();
		}
	}
}
