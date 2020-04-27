using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
	public class TrieWithArray
	{
		private TrieNode root;
		public TrieWithArray()
		{
			root = new TrieNode();
		}
		public void Insert(string word)
		{
			// to insert word we travese through trie till we have matching characters
			// if the character does not exist awe add new trie node
			// when we reach the last character in the word we mark that as end of word
			TrieNode cur = root;
			foreach (char c in word)c,
			{
				if (!cur.ContainsKey(c))
				{
					cur.Add(c);
				}
				cur = cur.Get(c);
			}
			cur.SetEndOfWord();
		}
		public bool Search(string word)
		{
			// traverse through trie, either till you reach end of word in the traversal
			// and check if its the end of word 
			//or in case there are no more nodes that you can traverse 
			//but you still have characters left in word then return false;
			TrieNode t = null;
			TrieNode cur = root;
			foreach (char c in word)
			{
				t = cur.Get(c);
				if (t == null)
					return false;
				cur = t;
			}
			return cur.IsEndOfWord();		
		}

	}

	public class TrieNode
	{
		// structure to store the characters
		// if array size of array or Radix
		// ContainsKey 
		// SetEndWord
		// Add Node
		// Get Node

		private TrieNode[] links;
		private bool isEnd;
		private int R = 26;

		public TrieNode()
		{
			links = new TrieNode[R];
			isEnd = false;
		}

		public bool ContainsKey(char c)
		{
			return links[c - 'a'] != null;
		}
		public void SetEndOfWord()
		{
			isEnd = true;
		}
		public bool IsEndOfWord()
		{
			return isEnd; 
		}

		public void Add(char c)
		{
			links[c - 'a'] = new TrieNode(); 
		}
		public TrieNode Get(char c)
		{
			return links[c - 'a'];
		}


	}
}
