using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicLinkList
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
			int i = 2;
			Node node = ll.head;
			while (node.data != i)
			{
				node = node.next;
			}
			//ll.tail.next = node;
			var res = IsLinkListCyclic(ll.head);
		}

		public static bool IsLinkListCyclic(Node head)
		{
			Node slow = head;
			Node fast = head;
			while (fast != null)
			{
				fast = fast.next;
				if (slow == fast)
					return true;
				if (fast != null)
					fast = fast.next;
				if (slow == fast)
					return true;
				slow = slow.next;			
			}
			return false;
		
		}
	}
}
