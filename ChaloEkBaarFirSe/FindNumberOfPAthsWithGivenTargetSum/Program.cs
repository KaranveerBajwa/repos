using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberOfPAthsWithGivenTargetSum
{
	class Program
	{
		static int count = 0;
		static void Main(string[] args)
		{
			TreeNode root = new TreeNode(10);
			root.left = new TreeNode(5);
			root.left.left = new TreeNode(3);
			root.left.left.left = new TreeNode(3);
			root.left.left.right = new TreeNode(-2);
			root.left.right = new TreeNode(2);
			root.left.right.right = new TreeNode(1);
			root.right = new TreeNode(-3);
			root.right.right = new TreeNode(11);
			var res = PathSum(root, 8);
		}

		public static int PathSum(TreeNode root, int sum)
		{
			if (root == null)
				return 0;
			TraversePath(root, sum);
			PathSum(root.left, sum);
					 PathSum( root.right, sum);
			return count;
		}

		public static void TraversePath(TreeNode root, int sum)
		{
			if (root == null)
				return;
			
				sum = sum - root.val;
				if (sum == 0)
					count++;
			TraversePath(root.left, sum);
				 TraversePath(root.right, sum);
			
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
