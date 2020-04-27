using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort012LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkList ll = new LinkList();
			ll.Append(0);
			ll.Append(2);
			ll.Append(0);
			ll.Append(1);
			ll.Append(0);
			ll.Append(2);
			ll.Append(1);
			var res = Sort012LinkedList(ll);
		}

		public static LinkList Sort012LinkedList(LinkList ll)
		{
			if (ll == null)
				return new LinkList();
			LinkList ll0 = new LinkList();
			LinkList ll1 = new LinkList();
			LinkList ll2 = new LinkList();
			Node cur = ll.head;
			while (cur != null)
			{
				switch (cur.data)
				{
					case 0:
						ll0.Append(cur.data);
						break;
					case 1:
						ll1.Append(cur.data);
						break;
					case 2:
						ll2.Append(cur.data);
						break;
				}
				cur = cur.next;
			}
				if (ll0 != null && ll.tail != null)
					ll0.tail.next = null;
				if (ll1 != null && ll.tail != null)
					ll1.tail.next = null;
				if (ll2 != null && ll2.tail != null)
					ll2.tail.next = null;
				LinkList result = new LinkList();
				AppendList(result, ll0);
				AppendList(result, ll1);
				AppendList(result, ll2);
			return result;
		}
		
		

		public static void AppendList(LinkList original, LinkList toAppend)
		{
			if (toAppend == null || toAppend.head == null)
				return;
			original.Append(toAppend.head);
			original.tail = toAppend.tail;
		}
	}
}
