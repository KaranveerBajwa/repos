using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCacheProblem
{
	public class LRUCache<K, V>
	{
		Dictionary<K, Node<K, V>> dict;
		Node<K, V> head;
		Node<K, V> tail;
		int capacity;
		public LRUCache(int size)
		{
			dict = new Dictionary<K, Node<K, V>>();
			capacity = size;
		}

		// when you read key , remove from the list and add it to the front
		public V Read(K key)
		{
			var node = dict[key];
			if (node == null)
				return default;
			Remove(key);
			Add(node.Key, node.Value);
			return node.Value;
		}

		public void Write(K key, V val)
		{
			if (dict.Count == capacity)
				Remove(head.Key);
			Add(key, val);
		}
		void Remove(K key)
		{
			if (!dict.ContainsKey(key))
				return;
			Node<K, V> toRemove = dict[key];
			RemoveFromLinkedList(toRemove);
			dict.Remove(key);
		}
		void Add(K key, V val)
		{
			Node<K, V> node = new Node<K, V>(key, val);
			AppendToLinkedList(node);
			dict.Add(key, node);
		}

		void AppendToLinkedList(Node<K, V> node)
		{
			if (head == null)
				head = node;
			else
				tail.Next = node;
			tail = node;
		}

		void RemoveFromLinkedList(Node<K,V> node)
		{
			if (head == node)
			{
				head = node.Next;				
			}
			else if (tail == node)
			{
				tail = node.Prev;
				tail.Next = null;
			}
			else
			{
				node.Prev.Next = node.Next;
				node.Next.Prev = node.Prev;
			}
		}

	}
}
