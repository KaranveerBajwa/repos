using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3 };
			int[] buffer = new int[arr.Length];
			IList<IList<int>> al = Subsets(arr);
			//PrintSteps(arr, buffer, 0, 0, al);
			Console.ReadKey();
		}

		public static IList<IList<int>> Subsets(int[] nums)
		{
			int[] buffer = new int[nums.Length];
			IList<IList<int>> al = new List<IList<int>>();
			PrintSteps(nums, buffer, 0, 0, al);
			return al;
		}

		public static  void PrintSteps(int[] arr,  int[] buffer, int curIndex, int bufferIndex, IList<IList<int>> al)
		{
			AddToList(al, buffer, bufferIndex);
			if (bufferIndex == buffer.Length || curIndex == arr.Length)
				return;
			

			for (int i = curIndex; i < arr.Length; i++)
			{
				buffer[bufferIndex] = arr[i];
				PrintSteps(arr,   buffer, i + 1, bufferIndex + 1, al);
			}
		}

		public static void AddToList(IList<IList<int>> al, int[] buffer, int bufferIndex)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < bufferIndex; i++)
				list.Add(buffer[i]);
			al.Add(list);
		}


	}
}
