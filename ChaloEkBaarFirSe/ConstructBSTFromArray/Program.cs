using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructBSTFromArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { -10, -3, 0, 5, 9 };
			var res = Construct(arr, 0, arr.Length - 1);
		}

		public static TreeNode Construct(int[] arr, int start, int end)
		{
			if (start > end)
				return null;
			int mid = start + (end - start) / 2;
			TreeNode root = new TreeNode(arr[mid]);
			root.Left = Construct(arr, start, mid - 1);
			root.Right = Construct(arr, mid + 1, end);
			return root;
		}
	}
}
