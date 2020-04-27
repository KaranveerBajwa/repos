using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace PrintCombinations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1,2,3,4,5,6,7};
			PrintCombinationsOfGivenLength(arr, 3);
			Console.Read();
		}

		public static void PrintCombinationsOfGivenLength(int[] arr, int size)
		{
			int[] buffer = new int[size];
			PrintCombinationsHelper(arr,buffer, 0,0);
		}

		static void PrintCombinationsHelper(int[] arr, int[] buffer, int startIndex, int bufferIndex)
		{
			if (bufferIndex == buffer.Length)
			{
				Print.PrintArray(buffer);
				return;
			}
			if (startIndex == arr.Length)
				return;
			for (int i = startIndex; i < arr.Length; i++)
			{
				buffer[bufferIndex] = arr[i];
				PrintCombinationsHelper(arr, buffer, i + 1, bufferIndex + 1);
			}

		}
	}
}
