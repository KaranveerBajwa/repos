using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBSTInSortedOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			Node node = new Node(4);
			node.left = new Node(2);
			node.left.left = new Node(1);
			node.right = new Node(5);
			PrintBST(node);
			Console.ReadKey();
		}

		public static void PrintBST(Node root)
		{
			if (root == null)
				return;
			PrintBST(root.left);
			Console.Write(root.val + " ");
			PrintBST(root.right);
		}

		}

	public class Node
	{
		public int val;
		public Node left;
		public Node right;
		public Node(int num)
		{
			val = num;
		}

	}


}
