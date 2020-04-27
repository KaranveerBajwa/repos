using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrieST
{
		public class Trie
		{
			private static int Radix = 256;
			private Node Root = new Node();


			internal class Node
			{
				public bool IsEndOfWord = false;
				public  Node[] Next = new Node[Radix];
			}

		public void Insert(string key)
		{
			Root = InsertHelper(Root, key, 0);
		}

		private Node InsertHelper(Node x, string key, int d)
		{
			if (x == null)
				x = new Node();
			if (d == key.Length)
			{
				x.IsEndOfWord = true;
				return x;
			}
			char c= key[d];
			x.Next[c] = InsertHelper(x.Next[c], key, d + 1);
			return x;
		}
	
	}
	}
