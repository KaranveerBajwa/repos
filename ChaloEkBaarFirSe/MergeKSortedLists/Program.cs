using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeKSortedLists
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode l1 = new ListNode(-8);
			l1.next = new ListNode(-7);
			l1.next.next = new ListNode(-7);
			l1.next.next.next = new ListNode(-5);
			l1.next.next.next.next = new ListNode(1);
			l1.next.next.next.next.next = new ListNode(1);

			l1.next.next.next.next.next.next = new ListNode(3);
			l1.next.next.next.next.next.next.next = new ListNode(4);


			ListNode l2 = new ListNode(-2);
		ListNode l3 = new ListNode(-10);	
			l3.next = new ListNode(-10);
			l3.next.next = new ListNode(-7);
			l3.next.next.next = new ListNode(0);
			l3.next.next.next.next = new ListNode(1);
			l3.next.next.next.next.next = new ListNode(3);
			ListNode l4 = new ListNode(2);
			ListNode[] arr = { l1, l2, l3,l4 };
			ListNode res = MergeKLists(arr);
			while(res !=null)
			{
				Console.Write(res.val + " ");
				res = res.next;
			}
			Console.ReadKey();
		}
		public static ListNode MergeKLists(ListNode[] lists)
		{
			// add each list to min heap, based on its first element and after that remove and add to the resulting list
			ListNode cur = new ListNode(-1);
			ListNode dummy = cur; 
			
			MinHeap minHeap = new MinHeap(lists.Length);
			foreach (ListNode l in lists)
			{
				minHeap.Insert(l);	
			}
			while(minHeap.Count() > 0)
			{
				cur.next = minHeap.GetMin();
				cur = cur.next;
			}
			return dummy.next;
		}
	}
	  public class ListNode
	{
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

}
