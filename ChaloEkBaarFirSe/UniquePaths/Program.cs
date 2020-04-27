using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePaths
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] matrix = new int[3, 2];
			int result = GetUniquePath(matrix);
		}

		public static int GetUniquePath(int[,] grid)
		{
			int[,] matrix = new int[grid.GetLength(0), grid.GetLength(1)];
			int row = grid.GetLength(0) - 1;
			int col = grid.GetLength(1) - 1;
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				matrix[0, i] = 1;
			}
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				matrix[i, 0] = 1;
			}

			for (int i = 1; i < matrix.GetLength(0); i++)
			{
				for (int j = 1; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
				}
			
			}

			return matrix[row, col];

		}


		static void GetUniquePathHelper(int[,] matrix, int row, int col, List<Cell> list, HashSet<List<Cell>> set)
		{
			if (row == matrix.GetLength(0) -1 && col == matrix.GetLength(1)-1)
			{
				set.Add(list);
				return;
			}
			if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
				return;
			Cell cell = new Cell(row , col);
			list.Add(cell);
			GetUniquePathHelper(matrix, row + 1, col,   list, set);
			GetUniquePathHelper(matrix, row, col + 1, list, set);
		}

		public class Cell {
			public int row;
			public int col;
			public Cell(int r, int c) 
			{
				row = r;
				col = c;
			}
		}
	}
}
