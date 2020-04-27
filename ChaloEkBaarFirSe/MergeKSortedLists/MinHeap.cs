using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
namespace MergeKSortedLists
{
	public class MinHeap
	{
		ListNode[] arr;
		int N;
		public MinHeap(int size)
		{
			arr = new ListNode[size + 1];
			N = 0;
		}

		public void Insert(ListNode list)
		{
			arr[++N] = list;
			Swim(N);
		}
		public ListNode GetMin()
		{
			// get the tops cur list node, move the pointer to next
			//, swap the list with list at location
			//if listCount > 0 , Decrement N
			ListNode n = arr[1];
			arr[1] = arr[1].next;
		//	ArrayHelper.Swap(arr, 1, N);
			if (arr[1] == null)
			{
				ArrayHelper.Swap(arr, 1, N);
				N = N - 1;
			}
			Sink(1);
			return n;
		}
		public int Count()
		{
			return N;
		}
		public void Swim(int k)
		{
			while (k > 1 && arr[k].val < arr[k / 2].val)
			{
				ArrayHelper.Swap(arr, k, k / 2);
				k = k / 2;
			}
		}
		public void Sink(int k)
		{
			while (k * 2 <= N)
			{
				int j = k * 2;
				if (j < N && arr[j + 1].val < arr[j].val)
					j = j + 1;
				if (arr[k].val < arr[j].val)
					break;
				ArrayHelper.Swap(arr, k, j);
				k = j;
			}
		}



	}
}
