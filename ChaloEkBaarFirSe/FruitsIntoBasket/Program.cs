using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsIntoBasket
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] arr = {'A', 'B', 'C', 'B', 'B', 'C'};
			Console.WriteLine(FindLength(arr));
			Console.ReadKey();
		}
		public static int FindLength(char[] arr)
		{
			if (arr == null || arr.Length == 0)
				return 0;
			int start = 0; int end = 0; int maxLength = 0;
			int left = 0;
			Dictionary<char, int> dict = new Dictionary<char, int>();
			for (int right = 0; right < arr.Length; right++)
			{
				char ch = arr[right];
				if (!dict.ContainsKey(ch))
					dict.Add(ch, 0);
				dict[ch] = dict[ch] + 1;
				while (dict.Count > 2)
				{
					dict[arr[left]] = dict[arr[left]] - 1;
					if (dict[arr[left]] == 0)
						dict.Remove(arr[left]);
					left++;
				}
				int curLength = right - left + 1;
				if (curLength > maxLength)
				{
					maxLength = curLength;
					start = left;
					end = right;
				}
			}
			for (int i = start; i <= end; i++)
				Console.Write(arr[i] + " ");
			Console.WriteLine();
			return maxLength;
		}
	}
}
