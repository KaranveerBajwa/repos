using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC489_RobotRoomCleaner
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] room = {
				{1,1,1,1,1,0,1,1 },
				{ 1,1,1,1,1,0,1,1 },
				{ 1,0,1,1,1,1,1,1 },
				{ 0,0,0,1,0,0,0,0},
				{ 1,1,1,1,1,1,1,1 } 
			};
			CleanRoom(room, 1, 3);
		}

		public static void CleanRoom(int[,] room, int row, int col)
		{
			int rowCount = room.GetLength(0);
			int colCount = room.GetLength(1);
			bool[,] visited = new bool[rowCount, colCount];
			for (int i = row; i < rowCount; i++)
				for (int j = col; j < colCount; j++)
				{
					if (!visited[i, j] && room[i, j] == 1)
						Clean(room, i, j, visited);
				}			
		}

		static void Clean(int[,] room, int row, int col, bool[,] visited)
		{
			Console.WriteLine($"Clean({row},{col})");
			visited[row, col] = true;
			if (!OutOfBound(room, row-1, col) && !visited[row-1, col] && room[row-1, col] == 1)
				Clean(room, row-1, col, visited);
			if (!OutOfBound(room, row+1, col) && !visited[row+1, col] && room[row +1 , col]== 1)
				Clean(room, row +1, col , visited);
			if (!OutOfBound(room, row, col - 1) && !visited[row, col - 1] && room[row, col -1] == 1)
				Clean(room, row, col - 1, visited);
			if (!OutOfBound(room, row, col + 1) && !visited[row, col + 1] && room[row, col + 1] == 1)
				Clean(room, row, col + 1, visited);		
		}

		static bool OutOfBound(int[,] room, int row, int col)
		{
			if (row < 0 || row >= room.GetLength(0) || col < 0 || col >= room.GetLength(1))
				return true;
			else
				return false;
		}

	}
}
