using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenList
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
			var res = OddEven(ll);
		}

		static LinkList OddEven(LinkList ll)
		{
			LinkList result = new LinkList();
			if (ll == null || ll.head == null)
				return result;
			LinkList odd = new LinkList();
			LinkList even = new LinkList();
			Node cur = ll.head;
			int index = 0;
			while (cur != null)
			{
				index = index + 1;
				LinkList destination = index % 2 == 0 ? even : odd;
				destination.Append(cur);
				cur = cur.next;
			}
			if (odd != null && odd.tail != null)
			{
				odd.tail.next = null;
			}
			if (even != null && even.tail != null)
			{
				even.tail.next = null;
			}
			AppendList(result, odd);
			AppendList(result, even);
			return result;
		}

		static void AppendList(LinkList original, LinkList toAppend)
		{
			if (toAppend == null || toAppend.head == null)
				return;
			original.Append(toAppend.head);
			original.tail = toAppend.tail;

		}
	}
}
