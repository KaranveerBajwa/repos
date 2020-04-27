using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchNationalProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {1,4,5,4,4,6,2,3 };
			DNP(arr,4);
		}

		static void DNP(int[] arr, int target)
		{
			int left = 0;
			int mid = 0;
			int right = arr.Length - 1;
			while (mid <= right)
			{
				if (arr[mid] > target)
				{
					Swap(arr, mid, right);
					right--;
				}
				else if (arr[mid] < target)
				{
					Swap(arr, left, mid);
					left++;
					mid++;
				}
				else
					mid++;
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
