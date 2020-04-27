using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNodesAtGivenLevel
{
	class Program
	{
		static void Main(string[] args)
		{
			Node root = new Node(1);
			root.left = new Node(2);
			root.right = new Node(3);
			root.right.right = new Node(7);
			root.left.left = new Node(4);
			root.left.right = new Node(5);
			var result = GetNodes(root, 3);
			foreach (var r in result)
			{
				Console.Write(r.value + ",");
			}
			Console.ReadKey();
		}

		static List<Node> GetNodes(Node root, int depth)
		{
			HashSet<Node> set = new HashSet<Node>();
			GetNodes(root, depth, set);
			return set.ToList();
		}

		static void GetNodes(Node current, int depth, HashSet<Node> set)
		{
			if (current == null)
			{
				return;
			}
			if (depth == 1)
			{
				set.Add(current);
			}

			GetNodes(current.left, depth - 1, set);
			GetNodes(current.right, depth - 1, set);
		
		}


		public class Node
		{
			public int value;
			public Node left;
			public Node right;
			public Node(int val)
			{
				value = val;
			}
		}

	}
}
