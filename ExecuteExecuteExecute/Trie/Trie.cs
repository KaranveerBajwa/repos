using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
	public class Trie
	{
		private Node root;
		public Trie()
		{
			root = new Node();
		}

		public void Insert(string word)
		{
			Node cur = root;
			foreach (char c in word)
			{
				if (!cur.ContainsKey(c))
				{
					cur.Add(c);
				}
				cur = cur.Next(c);
			}
			cur.SetEndOfWord();	
		}
		public bool Search(string word)
		{
			Node cur = root;
			foreach (char c in word)
			{
				if (!cur.ContainsKey(c))
					return false;
				cur = cur.Next(c);
			}
			return cur.IsEndOfWord();
		}

		public string GetPrefix()
		{
			Node cur = root;
			StringBuilder sb = new StringBuilder();
			while (cur != null && cur.Count() == 1 && !cur.IsEndOfWord())
			{
				char c = cur.GetKey();
				sb.Append(c);
				cur = cur.Next(c);
			}
			return sb.ToString();
		}
	}

	public class Node
	{
		Dictionary<char, Node> links;
		bool isEnd;
		public Node()
		{
			links = new Dictionary<char, Node>();
		}
		// SetEndOfWord
		// IsEndOfWord
		// ContainsKey
		// Add
		// Get
		public void SetEndOfWord()
		{
			isEnd = true;
		}
		public bool IsEndOfWord()
		{
			return isEnd;
		}
		public bool ContainsKey(char c)
		{
			return links.ContainsKey(c);
		}
		public void Add(char c)
		{
			links.Add(c, new Node());
		}
		public Node Next(char c)
		{
			return links[c];
		}
		//public IEnumerable<Node> GetAll()
		//{
		//	return links.Select;
		//}

		public int Count()
		{
			return links.Count;
		}

		public char GetKey()
		{
			var kvp = links.First();
			return kvp.Key;
		}



	}
}
