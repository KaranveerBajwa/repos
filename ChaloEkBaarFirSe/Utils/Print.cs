using System;

namespace Utils
{
	public static class Print
	{
		public static void PrintArray<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
