using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSearchWord
{
	public class WordDictionary
	{
		TrieNode root;
		public WordDictionary()
		{
			root = new TrieNode();
		}

		public void AddWord(string word)
		{
			if (word == null || word.Length == 0)
				return;
			TrieNode cur = root;
			foreach (char c in word)
			{
				if (!cur.Contains(c))
					cur.Add(c);
				cur = cur.Next(c);
			}
			cur.SetEndOfWord();
		}

		public bool Search(string word)
		{
			if (word == null || word.Length == 0)
				return true;
			TrieNode cur = root;
			return SearchHelper(word, cur);
		
		}

		public bool SearchHelper(string word, TrieNode cur)
		{
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == '.')
				{
					foreach (char c in cur.GetAll())
					{
						if (SearchHelper(word.Substring(i + 1, word.Length - i - 1), cur.Next(c)))
							return true;
					}
				}
				else
				{
					if (!cur.Contains(word[i]))
						return false;
					cur = cur.Next(word[i]);
				}	
			}
			return true;
		}

	}
}
