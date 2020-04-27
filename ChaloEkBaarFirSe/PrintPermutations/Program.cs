using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace PrintPermutations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 5 };
			Permutations(arr, 3);
			Console.Read();
		}

		public static void Permutations(int[] arr, int size)
		{
			if (arr == null || arr.Length == 0 || size > arr.Length)
				return;
			int[] buffer = new int[size];
			bool[] inBuffer = new bool[arr.Length];
			PermutationsHelper(arr, buffer, inBuffer, 0);		
		}

		static void PermutationsHelper(int[] arr, int[] buffer, bool[] inBuffer, int bufferIndex)
		{
			if (bufferIndex >= buffer.Length)
			{
				Print.PrintArray(buffer);
				return;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				if (!inBuffer[i])
				{
					inBuffer[i] = true;
					buffer[bufferIndex] = arr[i];
					PermutationsHelper(arr,buffer,inBuffer,bufferIndex + 1);
					inBuffer[i] = false;
				
				}
			
			}
		
		}

	}
}
