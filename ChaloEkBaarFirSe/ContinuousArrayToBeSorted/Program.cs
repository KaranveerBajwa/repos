using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousArrayToBeSorted
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] arr = { 0,2,3,1,8,6,9};
			ArrayToBeSorted(arr);
		}

		public static void ArrayToBeSorted(int[] arr)
		{
			int minDip = GetMinDipIndex(arr);
			int maxDip = GetBumpIndex(arr);
			int max = Int32.MinValue;
			int min = Int32.MaxValue;
			for (int k =minDip; k <= maxDip; k++)
			{
				if (arr[k] < min)
					min = arr[k];

				if (arr[k] > max)
					max = arr[k];
			}

			while (minDip > 0 && arr[minDip - 1] > min)
				minDip--;
			while (maxDip < arr.Length && arr[maxDip + 1] < max)
				maxDip++;


			
		
		}
		static int GetMinDipIndex(int[] arr)
		{
			int dipIndex  = -1;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < arr[i - 1])
				{
					dipIndex = i;
					break;
				}
			}
			return dipIndex;
		}

		static int GetBumpIndex(int[] arr)
		{
			int bumpIndex = arr.Length - 1;
			for (int i = arr.Length -1; i >= 1; i--)
			{
				if (arr[i - 1] > arr[i])
				{
					bumpIndex = i - 1;
					break;
				}
			}
			return bumpIndex;
		}

	}
}
