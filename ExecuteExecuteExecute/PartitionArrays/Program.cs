using Utils;
namespace PartitionArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 4, 2, 0, 1, 0, 3, 0 };
			Partition(arr);
			int[] dnp = { 4,4,4,4,4,4,4,4 ,0,0,0};
			DutchNationalFlag(dnp, 4);
			int[] rbw = {0,1,2,2,0,0,1,1,2,1 };
			RedBlueWhite(rbw);

		}

		public static void Partition(int[] arr)
		{
			int left = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 0)
				{
					Util.Swap(arr, ++left, i);
				}
			}
		}

		/*
		 * For example, if A = [5,2,4,4,6,4,4,3] 
		 * and pivot = 4 -> result = [3,2,4,4,4,4,6,5] 
		 */
		public static void DutchNationalFlag(int[] arr, int pivotElement)
		{
			int left = 0;
			int right = arr.Length -1 ;
			int middle = 0;
			while (middle <= right)
			{
				if (arr[middle] < pivotElement)
				{
					Util.Swap(arr, left, middle);
					left++;
					middle++;
				}
				else if (arr[middle] > pivotElement)
				{
					Util.Swap(arr, middle, right);
					right--;
				}
				else
					middle++;
			}
		}

		public static void RedBlueWhite(int[] arr)
		{
			int pivotElement = 1;
			int left = 0;
			int right = arr.Length - 1;
			int middle = 0;
			while (middle <= right)
			{
				if (arr[middle] < pivotElement)
				{
					Util.Swap(arr, left, middle);
					left++;
					middle++;
				}
				else if (arr[middle] > pivotElement)
				{
					Util.Swap(arr, middle, right);
					right--;
				}
				else
					middle++;
			}




		}

	
	}
}
