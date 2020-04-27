using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorianTriplet
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 3, 5, 13, 25, 13 };
			HashSet<int> hs = new HashSet<int>();
			for (int k = 0; k < arr.Length; k++)
				hs.Add(arr[k] * arr[k]);
			for (int i = 0; i < arr.Length; i++)
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (hs.Contains(arr[i] * arr[i] + arr[j] * arr[j]))
					{
						Console.WriteLine($"{i} , {j} True");
						break;
					}
				}
		}
	}
}
