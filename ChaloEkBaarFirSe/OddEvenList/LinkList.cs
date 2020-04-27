namespace OddEvenList
{
	public class LinkList
	{
		public Node head;
		public Node tail;
		public LinkList()
		{
		}
		public void Append(int n)
		{
			Node newNode = new Node(n);
			Append(newNode);
		}

		public void Append(Node node)
		{
			if (head == null)
				head = node;
			else
				tail.next = node;
			tail = node;
		}

	}

	public class Node
	{
		public Node next;
		public int data;
		public Node(int n)
		{
			data = n;
		}
	}
}