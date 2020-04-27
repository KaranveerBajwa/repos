using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCacheProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			Node<string, int> node = new Node<string, int>("hello", 1);
			Node<int, string> node2 = new Node<int, string>(1, "Hello");
		}
	}
}
