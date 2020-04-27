using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLinkListPalindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkList ll = new LinkList();
			ll.Append(1);
			ll.Append(2);
			ll.Append(3);
			ll.Append(3);
			ll.Append(1);
			var res = IsPalindrome(ll.head);
		}

		public static bool IsPalindrome(Node head)
		{
			if(head == null)
				return true;
			Node slow = head;
			Node fast = head;
			while (fast.next != null)
			{
				fast = fast.next;
				if(fast.next != null)
					fast = fast.next;
				slow = slow.next;
			}

			Node end = Reverse(slow);
			Node start = head;
			while (start!=null && end!=null)
			{
				if (start.data != end.data)
					return false;
				start = start.next;
				end = end.next;
			}
			return true;
		}

		static Node Reverse(Node node)
		{
			Node prev = null;
			Node curr = node;
			Node next;
			while (curr != null)
			{
				next = curr.next;
				curr.next = prev;
				prev = curr;
				curr = next;
			}
			return prev;		
		}


	}
}
