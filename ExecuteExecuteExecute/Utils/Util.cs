using System;

namespace Utils
{
	public static class Util
	{
		public static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}


	}
}
