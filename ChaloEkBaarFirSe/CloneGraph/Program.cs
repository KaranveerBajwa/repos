using GraphsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneGraph
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph g = new Graph(7);
			g.Add(1, 2);
			g.Add(1, 3);
			g.Add(2, 4);
			g.Add(3, 4);
			g.Add(3, 5);
			g.Add(5, 6);
			g.Add(4, 6);
			 
		}
		public static Node Clone(Node node)
		{
			if (node == null)
				return null;
			Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
			Queue<Node> q = new Queue<Node>();
			Node root = new Node(node.val);
			q.Enqueue(node);
			dict.Add(node, root);
			while (q.Count > 0)
			{
				Node curr = q.Dequeue();
				foreach (Node v in curr.neighbors)
				{
					if (!dict.ContainsKey(v))
					{
						Node newNode = new Node(v.val);
						dict.Add(v, newNode);
						q.Enqueue(v);
					}

					dict[curr].neighbors.Add(dict[v]);
				}

			}


			return root;
		}

	}

	public class Node
	{
		public int val;
		public List<Node> neighbors;
		public Node()
		{
			val = 0;
			neighbors = new List<int>();
		}

		public Node(int val)
		{
			this.val = val;
			neighbors = new List<int>();
		}
		public Node(int val, List<int> list)
		{
			this.val = val;
			neighbors = list;
		}
	}

}
