using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCacheProblem
{
	public class Node<K, V>
	{
		public Node<K,V> Next { get; set; }
		public Node<K, V> Prev { get; set; }
		public K Key { get; set; }
		public V Value { get; set; }
		public Node(K key, V val)
		{
			Key = key;
			Value = val;
		}

	}
}
