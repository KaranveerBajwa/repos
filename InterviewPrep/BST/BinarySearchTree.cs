using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
	public class BinarySearchTree
	{
		private Node Root;
		
		public class Node {
			public int Data;
			public Node Left;
			public Node Right;
			public Node(int num)
			{
				Data = num;
			}

		}
		public void Insert(int num)
		{
			Root = Insert(Root, num);
		}


		public int GetMin()
		{
			Node curNode = Root;
			while (curNode.Left != null)
			{
				curNode = curNode.Left;
			}
			return curNode.Data;
		}

		public int GetMax()
		{
			Node curNode = Root;
			while (curNode.Right != null)
			{
				curNode = curNode.Right;
			}
			return curNode.Data;
		}

		public Node GetFloor(int num)
		{
			return GetFloor(Root, num);

		}
		
		private Node GetFloor(Node curNode, int num)
		{
			if (curNode == null)
				return null;
			if (curNode.Data == num)
				return curNode;
			else if (num < curNode.Data)
				return GetFloor(curNode.Left, num);
			Node t = GetFloor(curNode.Right, num);
			if (t != null)
				return t;
			else
				return curNode;
		}


		private Node Insert(Node curNode, int num)
		{
			if (curNode == null) return new Node(num);
			if(num < curNode.Data)
			{
				curNode.Left = Insert(curNode.Left, num);
			}
			else
			{
				curNode.Right = Insert(curNode.Right, num);
			}
			return curNode;
		}
	

	}
}
