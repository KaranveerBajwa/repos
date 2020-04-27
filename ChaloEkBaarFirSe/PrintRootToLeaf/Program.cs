using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRootToLeaf
{
	class Program
	{
		static void Main(string[] args)
		{

			Node n = new Node(6);
			n.left = new Node(4);
			n.left.right = new Node(15);
			n.left.left = new Node(3);
			n.left.left.left = new Node(2);
			n.right = new Node(5);
			n.right.left = new Node(10);
			Print(n);

		}

		static void Print(Node root)
		{
			int[] path = new int[1000];
			PrintHelper(root, path, 0);
		}

		static void PrintHelper(Node cur, int[] path, int pathLen)
		{
			if (cur == null)
			{
				return;
			}
			path[pathLen] = cur.val;
			pathLen++;

			if (cur.left == null && cur.right == null)
			{
				for(int i  =0; i < pathLen; i++)
				{
					Console.Write(path[i]);
				}
				Console.WriteLine();
				return;
			}
			else
			{				
				PrintHelper(cur.left, path, pathLen);
				PrintHelper(cur.right, path, pathLen);
			}
		}
		class Node
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

}
