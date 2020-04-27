using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeAndDeserializeBinaryTree
{
	public class Codec
	{


		public List<string> serialize(TreeNode root)
		{
			List<string> l = new List<string>();
			SerializeHelper(root, l);
			return l;
		}
		void SerializeHelper(TreeNode root, List<string> l)
		{
			if (root == null)
			{
				l.Add(null);
				return;
			}
			l.Add(root.val.ToString());
			SerializeHelper(root.left, l);
			SerializeHelper(root.right, l);
		}


		public TreeNode deserialize(List<string> l)
		{
			if (l.Count == 0 || l[0] == null)
			{
				l.RemoveAt(0);
				return null;
			}
			TreeNode root = new TreeNode(Convert.ToInt32(l[0]));
			l.RemoveAt(0);
			root.left = deserialize(l);
			root.right = deserialize(l);
			return root;
		}

	


	}
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}
}
