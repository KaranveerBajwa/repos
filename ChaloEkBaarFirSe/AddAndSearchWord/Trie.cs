using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSearchWord
{
	class Trie
	{
		TrieNode root;
		public Trie()
		{
			root = new TrieNode();
		}
		public void AddWord(string str)
		{
			if (str == null)
				return;
			TrieNode cur = root;
			foreach (char c in str)
			{
				if (!cur.Contains(c))
					cur.Add(c);
				cur = cur.Next(c);
			}
			cur.SetEndOfWord();
		
		}

		public bool Search(string str)
		{
			if (str == null)
				return true;
			TrieNode cur = root;
			return Search(str, cur);
		}

		public bool Search(string str, TrieNode cur)
		{
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == '.')
				{
					IEnumerable<char> chars = cur.GetAll();
					foreach (var c in chars)
					{
						if (Search(str.Substring(i + 1, str.Length - i - 1), cur.Next(c)))
							return true;
					}
				}
				else
				{
					if (!cur.Contains(str[i]))
						return false;

					cur = cur.Next(str[i]);
				}
			}
			return cur.IsEndOfWord();
		}

	}
	public class TrieNode 
	{
		Dictionary<char, TrieNode> dict;
		bool isEndOfWord;
		public TrieNode()
		{
			dict = new Dictionary<char, TrieNode>();
		}
		public void Add(char c)
		{
			dict.Add(c, new TrieNode());
		}
		public TrieNode Next(char c)
		{
			return dict[c];
		}
		public IEnumerable<char> GetAll()
		{
			List<char> list = new List<char>();
			foreach (var kvp in dict)
			{
				list.Add(kvp.Key);
			}
			return list;
		}
		public bool IsEndOfWord()
		{
			return isEndOfWord;
		}
		public bool Contains(char c)
		{
			return dict.ContainsKey(c);
		}
		public void SetEndOfWord()
		{
			isEndOfWord = true;
		}



	}
}
