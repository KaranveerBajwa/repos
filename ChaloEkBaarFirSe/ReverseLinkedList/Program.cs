using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkList ll = new LinkList();
			ll.Append(1);
			ll.Append(2);
			ll.Append(3);
			ll.Append(4);
			ll.Append(5);
			Node[] res = Reverse(ll.head);
			ll.head = res[0];
			ll.tail = res[1];
			ll.Append(7);
		}

		public static Node[] Reverse(Node head)
		{
			Node curr = head;
			Node tail = head;
			Node next;
			Node prev = null;
			while (curr != null )
			{
				next = curr.next;
				curr.next = prev;
				prev = curr;
				curr = next;				
			}
			return new Node[] { prev, tail};
		}
	}
}
