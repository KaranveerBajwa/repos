using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructBinaryTreeFromLinkList
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

		}

		public static TreeNode SortedListToBST(ListNode head)
		{
			if (head == null)
				return null;
			// Get the tail of linklist
			ListNode tail = head;
			while (tail.next != null)
			{
				tail = tail.next;
			}
			return SortedListToBSTHelper(head, tail);
		}

		public static TreeNode SortedListToBSTHelper(ListNode head, ListNode tail)
		{
			if (head == null || tail == null)
				return null;
			MedianPair mp = FindMedian(head, tail);
			TreeNode root = new TreeNode(mp.Median.val);
			root.left = SortedListToBSTHelper(head, mp.Previous);
			root.right = SortedListToBSTHelper(mp.Median.next, tail);
			return root;



			}


	static MedianPair FindMedian(ListNode head, ListNode tail)
		{
			ListNode slow = head;
			ListNode previous = null;
			ListNode fast = head;
			while (fast != tail)
			{
				fast = fast.next;
				if (fast != tail)
				{
					fast = fast.next;
				}
				previous = slow;
				slow = slow.next;
			}
			return new MedianPair(previous, slow);
		}

		public class MedianPair
		{
			public ListNode Median { get; set; }
			public ListNode Previous { get; set; }

			public MedianPair(ListNode prev, ListNode median)
			{
				Median = median;
				Previous = prev;
			}

		}
	}

	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

}
