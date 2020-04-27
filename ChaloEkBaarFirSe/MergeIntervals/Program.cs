using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervals
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] A = new int[4][];
			A[0] = new int[] { 0, 2 };
			A[1] = new int[] { 5, 10 };
			A[2] = new int[] { 13, 23 };
			A[3] = new int[] { 24, 25 };
			int[][] B = new int[4][];
			B[0] = new int[] { 1,5 };
			B[1] = new int[] { 8, 12 };
			B[2] = new int[] { 15, 24 };
			B[3] = new int[] { 25, 26 };
			var res = IntervalIntersection(A, B);

		}

		public static int[][] IntervalIntersection(int[][] A, int[][] B)
		{
			if (A == null || B == null || A.Length == 0 || B.Length == 0)
				return null;
			int i = 0; 
			int j = 0;
			List<int[]> list = new List<int[]>();
			while (i < A.Length && j < B.Length)
			{
				
				int lo = Math.Max(A[i][0], B[j][0]);
				int hi = Math.Min(A[i][1], B[j][1]);
				if (lo <= hi)
				{
					list.Add(new int[] { lo, hi });
				}
				if (A[i][1] < B[j][1])
				{
					i++;
				}
				else
					j++;			
			}
			return list.ToArray();
		}
	}
}
