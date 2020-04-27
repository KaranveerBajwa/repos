using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueReconstructionByHeight
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] people = new int[6][];
			people[0] = new int[] { 7, 1 };
			people[1] = new int[] { 4, 4 };
			people[2] = new int[] { 7, 0 };
			people[3] = new int[] { 5, 2 };
			people[4] = new int[] { 6, 1 };
			people[5] = new int[] { 5, 0 };
			var list = people.OrderByDescending(p => p[0]).ToList();
			int i = 0;
			while(i < list.Count)
			{
				int j = i;
				while (j > 0 && list[j][1] <= list[j - 1][1] )
				{
					Swap(list, j-1, j);
					j--;
				}
				i++;
			}
		
		}

		private static void Swap(List<int[]> list, int i, int j)
		{

				var temp = list[i];
				list[i] = list[j];
				list[j] = temp;
		
		}
	}
}
