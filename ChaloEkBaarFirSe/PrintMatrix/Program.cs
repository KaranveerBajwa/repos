using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			char[,] matrix = {
				{ 'f', 'a', 'c', 'i'},{ 'o', 'b', 'q', 'p'},{ 'a', 'o', 'a', 'm'},{ 'm', 'a', 's', 's'}	};
			bool result = Print(matrix);
		}


		static bool Print(char[,] matrix)
		{
			string target = "foam";
			if ( WordSearchBottom(matrix, 0, 0, "", target) || WordSearchRight(matrix, 0, 0, "", target) )
				return true;
			else
				return false;
			
		}

		static bool WordSearchRight(char[,] matrix, int row, int col, string s, string target)
		{
			if (row >= matrix.GetLength(0))
			{
				return false;
			}
			
			if (s == target)
				{
					Console.WriteLine(s);
					return true;
				}
		
			string str = "";
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				str += matrix[row, i];
				if (str.Length == target.Length &&	 WordSearchRight(matrix, row + 1, 0, str, target))
				return true;
			}
			return false;
		}

		static bool WordSearchBottom(char[,] matrix, int row, int col, string s, string target)
		{
			if (col >= matrix.GetLength(1))
				return false;
			if (s == target)
			{
				Console.WriteLine(s);
				return true;
			}

			string str = "";
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				str += matrix[i, col];
				if (str.Length == target.Length && WordSearchBottom(matrix, 0, col + 1,str, target))
				{
					return true;
				}
			}
			return false;
		
		}

		static void PrintHelper(char[,] matrix, int row, int col, Direction direction, string s)
		{
			Console.WriteLine($"PrintHelper({row}, {col}, {s})");
			if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
			{
				Console.WriteLine(s);

				return;
			}

		}


		enum Direction { 
		Right,
		Bottom,
		Diagonal
		}
		#region KabhiMaukaMile to hum bhi hain
		////if (direction == Direction.Right)
		//PrintHelper(matrix, row, col + 1, direction, s + matrix[row, col]);
		//PrintHelper(matrix, row+1, col , direction, s + matrix[row, col]);
		//PrintHelper(matrix, row + 1, col + 1, direction, s + matrix[row, col]);
		////if (direction == Direction.Bottom)
		////	PrintHelper(matrix, row + 1, col, direction, s + matrix[row, col]);
		////if (direction == Direction.Diagonal)
		////	PrintHelper(matrix, row + 1, col + 1, direction, s + matrix[row, col]);

		#endregion

	}
}
