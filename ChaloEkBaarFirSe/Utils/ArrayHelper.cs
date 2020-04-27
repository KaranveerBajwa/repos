using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
	public static class ArrayHelper
	{
		public static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public static void Swap<T>(T[] arr, int i, int j)
		{
			T temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public static void PrintArray<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
		public static void PrintIntArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}

	}
}
