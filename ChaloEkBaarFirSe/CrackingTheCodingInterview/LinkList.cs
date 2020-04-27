using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
	public class LinkList
	{
		public Node head;
		public Node tail;
		public void Append(int n)
		{
			Node newNode = new Node(n);
			Append(newNode);
		}

		public void Append(Node n)
		{
			if (head == null)
				head = n;
			else
				tail.next = n;
			tail = n;
		}

	}
	public class Node 
	{
		public int data;
		public Node next;
		public Node(int n)
		{
			data = n;
			next = null;
		}
	}
}
