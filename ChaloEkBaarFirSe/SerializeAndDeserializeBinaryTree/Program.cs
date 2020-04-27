using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeAndDeserializeBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{

			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(2);
			root.left.left = new TreeNode(3);
			root.left.right = new TreeNode(4);
			root.right = new TreeNode(5);
			Codec c = new Codec();
			List<string> list = c.serialize(root);
			foreach (var l in list)
			{
				Console.Write(l + ",");
			}

			TreeNode res = c.deserialize(list);
			Console.ReadKey();
		}

	}
}
