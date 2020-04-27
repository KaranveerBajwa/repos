using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSortedDoublyLinkedListFromBST
{
	class Program
	{
    static Node first = null;
    static Node last = null;
		static void Main(string[] args)
		{
      Node root = new Node(4);
      root.left = new Node(2);
      root.left.left = new Node(1);
      root.left.right = new Node(3);
      root.right = new Node(5);
      var node = TreeToDoublyList(root);
		}

    public static  Node TreeToDoublyList(Node root)
    {
      if (root == null)
        return null;
      TreeToDoublyListHelper(root);
      last.right = first;
      first.left = last;
      return first;
    }

    public static  void TreeToDoublyListHelper(Node cur)
    {
      if (cur == null)
        return;
      TreeToDoublyListHelper(cur.left);
      if (last != null)
      {
        last.right = cur;
        cur.left = last;
      }
      else {
        first = cur;
      }
      last = cur;
      TreeToDoublyListHelper(cur.right);
    }
  }

  public class Node
  {
    public int val;
    public Node left;
    public Node right;

    public Node() { }

    public Node(int _val)
    {
      val = _val;
      left = null;
      right = null;
    }

    public Node(int _val, Node _left, Node _right)
    {
      val = _val;
      left = _left;
      right = _right;
    }
  }
 
 
}
