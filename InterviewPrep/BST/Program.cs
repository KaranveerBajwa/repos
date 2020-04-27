using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
	class Program
	{
		static void Main(string[] args)
		{
			BinarySearchTree bst = new BinarySearchTree();
			bst.Insert(10);
			bst.Insert(5);
			bst.Insert(11);
			bst.Insert(8);
			bst.Insert(9);
			bst.Insert(6);
			var res =  bst.GetMin();
			var t = bst.GetFloor(7);

		}
	}
}
