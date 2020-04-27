using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
	public class LinkedList
	{
		public Node Head { get; set; }
		public Node Tail { get; set; }

		public void Append(Node newNode)
		{
			if (Head == null)
			{
				Head = newNode;
			}
			else
			{
				Tail.Next = newNode;
			}
			Tail = newNode;
		}

		public LinkedList Sort012(Node Head)
		{
			Node curNode = Head;
			LinkedList ll0 = new LinkedList();
			LinkedList ll1 = new LinkedList();
			LinkedList ll2 = new LinkedList();
			LinkedList result = new LinkedList();
			while (curNode != null)
			{
				switch (curNode.Data)
				{
					case 0:
						ll0.Append(curNode);
						break;
					case 1:
						ll1.Append(curNode);
						break;
					case 2:
						ll2.Append(curNode);
						break;
					default:
						break;
				}
				curNode = curNode.Next;
			}
			if(ll0.Head !=null)
			{
				ll0.Tail.Next = null;
				result.Append(ll0.Head);
				result.Tail=ll0.Tail;
			}

			if (ll1.Head != null)
			{
				ll1.Tail.Next = null;
				result.Append(ll1.Head);
				result.Tail = ll1.Tail;
			}

			if (ll2.Head != null)
			{
				ll2.Tail.Next = null;
				result.Append(ll2.Head);
				result.Tail = ll2.Tail;
			}


			return result;
		}

		public void SplitEvenOdd(Node Head, LinkedList oddList, LinkedList evenList)
		{
			int index = 0;
			Node curNode = Head;
			while (curNode != null)
			{
				index += 1;
				if (index % 2 == 0)
				{
					evenList.Append(curNode);
				}
				else {
					oddList.Append(curNode);
				}
				curNode = curNode.Next;
			}
			if (oddList.Tail != null)
			{
				oddList.Tail.Next = null;
			}

			if (evenList.Tail != null)
			{
				evenList.Tail.Next = null;
			}

		}
	
	
	}
	public class Node { 
		public Node Next { get; set; }
		public int Data { get; set; }

		public Node(int data, Node next = null)
		{
			this.Data = data;
			this.Next = next;
		}
	}
}
