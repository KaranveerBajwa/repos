using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
	public static class _2_1RemoveDups
	{

		public static  void  RemoveDups(Node head)
		{
			if (head == null)
				return head;
			Node current = head;
			head = current;
			HashSet<Node> hs = new HashSet<Node>();
			hs.Add(current);
			while (current != null && current.next != null)
			{
				if (hs.Contains(current.next))
				{
					current.next = current.next.next;
				}
				else
				{
					hs.Add(current.next);
					current = current.next;
				}
			}
			return current;
		
		}

		public static void RemoveDupsWithoutExtraMem(Node head)
		{
			Node current = head;
			while (current != null)
			{
				Node runner = current;
				while(runner)
			
			}
		}
	}
}
