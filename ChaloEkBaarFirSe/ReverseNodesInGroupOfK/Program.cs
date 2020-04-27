using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNodesInGroupOfK
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode l = new ListNode(1);
		 
			l.next = new ListNode(2);
			l.next.next = new ListNode(3);
			l.next.next.next = new ListNode(4);
			l.next.next.next.next = new ListNode(5);
			//var res1 = ReverseKGroup(l, 2);
			var res2 = ReverseKGroup(l, 2);
		}

		public static ListNode ReverseKGroup(ListNode head, int k)
		{
			ListNode cur = head;
			int numNodes = 0;
			while (cur != null)
			{
				cur = cur.next;
				numNodes = numNodes + 1;
			}
			int rounds = numNodes / k;
			return ReverseKGroupHelper(head, k, rounds);
		}

		public static ListNode ReverseKGroupHelper(ListNode head, int k, int rounds)
		{
			
      ListNode next = null;
      ListNode prev = null;
			ListNode current = head;
      int count = 0;
 
				/* Reverse first k nodes of linked list */
				while (count < k && current != null)
				{
					next = current.next;
					current.next = prev;
					prev = current;
					current = next;
					count++;
				}

				/* next is now a pointer to (k+1)th node  
						Recursively call for the list starting from current.  
						And make rest of the list as next of first node */
				if (next != null)
				{
					if (rounds -1 > 0)
					{
						head.next = ReverseKGroupHelper(next, k, rounds - 1);
					}
					else
						head.next = next;
				}
		 
      // prev is now head of input list  
      return prev;
    }


	}
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}



}
