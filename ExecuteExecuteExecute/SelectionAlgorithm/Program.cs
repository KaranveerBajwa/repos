using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionAlgorithm
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "abcdefgh";
			string[] prefixes = new string[s.Length];
			for (int i = s.Length; i >=0; i--)
			{
				prefixes[i] = s.Substring(i, );
				//Console.WriteLine(prefixes[i]);
			}
			Array.Sort(prefixes);
			foreach (var c in prefixes)
				Console.WriteLine(c);

		}

		static int[] GetKClosest(int[] arr, int k)
		{
			int res =GetKClosestHelper(arr, 0, arr.Length, k-1);
			int[] resArr = new int[k];
			for (int i = 0; i < k; i++)
			{
				resArr[i] = arr[i];
			}
			return resArr;
		}

		static int GetKClosestHelper(int[] arr, int start, int end, int targetIndex)
		{
			int length = arr.Length;
			Random rnd = new Random();
			int pivotIndex = rnd.Next(0, length);
			int partitionIndex = Partition(arr, 0, length - 1, pivotIndex);
			if (partitionIndex > targetIndex)
			{
				// MoveLeft	
				return GetKClosestHelper(arr, start, partitionIndex - 1, targetIndex);
			}
			else if (partitionIndex < targetIndex)
			{
				// move right
				return GetKClosestHelper(arr, partitionIndex + 1, end, targetIndex);
			}
			else
				return partitionIndex;
		}

		static int Partition(int[] arr, int start, int end, int pivotIndex)
		{
			Swap(arr, start, pivotIndex);
		
			int left = 0;
			for (int i = start + 1; i <= end; i++)
			{
				if (arr[i] <= arr[start])
				{
					Swap(arr, ++left, i);
				}
			}
			Swap(arr, left, start);
			return left;
		}

		static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	
	}
}
