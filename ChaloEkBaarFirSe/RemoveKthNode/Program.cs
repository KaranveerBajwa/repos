using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKthNode
{
	class Program
	{
		static void Main(string[] args)
		{
			Node root = new Node(0);
			root.next = new Node(1);
			root.next.next = new Node(2);
			root.next.next.next = new Node(3);
			root.next.next.next.next = new Node(4);
			RemoveKth(root, 2);
		}

		public static void RemoveKth(Node root, int k)
		{
			Node current = root;
			Node right = root;
			for (int i = 0; i < k; i++)
			{
				if (right == null)
					return;
				right = right.next;
			}
			while (right.next != null)
			{
				current = current.next;
				right = right.next;
			}
			Node temp = current.next;			
			current.next = current.next.next;
			temp.next = null;
		}

		public class Node
		{
			public int val;
			public Node next;
			public Node(int val)
			{
				this.val = val;
			}
		}
	
	}
}
