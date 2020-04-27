using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDecreasingSquareArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { -4, -2, -1, 0, 4, 5 };
			SortSquares(arr);
		}


		public static  void SortSquares(int[] arr)
		{
			int left = 0;
			int right = arr.Length - 1;
			while (left <= right)
			{
				if (Math.Abs(arr[left]) <= Math.Abs(arr[right]))
				{

					right--;
				}
				else
				{
					Swap(arr, left, right);
					left++;
					right--;
				}
			}
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = arr[i] * arr[i];			
			}
		
		}


		static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	
	}
}
