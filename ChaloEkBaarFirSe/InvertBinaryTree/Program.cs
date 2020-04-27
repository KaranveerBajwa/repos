using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
			TreeNode root = new TreeNode(4);
			root.left = new TreeNode(2);
			root.left.left = new TreeNode(1);
			root.left.right = new TreeNode(3);
			root.right = new TreeNode(7);
			root.right.left = new TreeNode(6);
			root.right.right = new TreeNode(9);
			root = InvertTree(root);
		}

		public static  TreeNode InvertTree(TreeNode root)
		{
			if (root == null)
				return root;
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				TreeNode current = queue.Dequeue();
				TreeNode temp = current.left;
				current.left = current.right;
				current.right = temp;
				if (current.left != null) queue.Enqueue(current.left);
				if (current.right != null) queue.Enqueue(current.right);
			}
			return root;
		}
	
  public class TreeNode
		{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
	}
}
