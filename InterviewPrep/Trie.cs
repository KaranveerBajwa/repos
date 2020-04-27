using System;
namespace LinkedLists
{
	public class Trie
	{
		public int Radix { get; set; }
		public Node Root = new Node();
		public Trie()
		{
		}

		private class Node
		{
			private bool IsEndOfWord = false;
			private Node[] Next = new Node[Radix];
		}
	}
}