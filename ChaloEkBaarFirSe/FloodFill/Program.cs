using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] image = new int[3][];
			image[0] = new int[]{ 1,1,1};
			image[1] = new int[] { 1, 1, 0 };
			image[2] = new int[] {1, 0, 1 };
			int newColor = 2;
			var res = FloodFill(image, 1, 1, newColor);
			for (int i = 0; i < image.Length; i++)
			{
				for (int j = 0; j < image[0].Length; j++)
				{
					Console.Write(image[i][j] + "  ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}

		public static  int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
		{
			bool[,] visited = new bool[image.Length, image[0].Length];
			int oldColor = image[sr][sc];
			FloodFillHelper(image, sr, sc, newColor, oldColor, visited);

			return image;
		}

		static void FloodFillHelper(int[][] image, int sr, int sc, int newColor, int oldColor, bool[,] visited)
		{
			if (!OutOfBound(image, sr, sc) && !visited[sr, sc] && image[sr][sc] == oldColor)
			{
				visited[sr, sc] = true;
				image[sr][sc] = newColor;
				FloodFillHelper(image, sr - 1, sc, newColor, oldColor, visited);
				FloodFillHelper(image, sr + 1, sc, newColor, oldColor, visited);
				FloodFillHelper(image, sr, sc - 1, newColor, oldColor, visited);
				FloodFillHelper(image, sr, sc + 1, newColor, oldColor, visited);
			}
		}

		static bool OutOfBound(int[][] image, int sr, int sc)
		{
			if (sr >= 0 && sr < image.Length && sc >= 0 && sc < image[0].Length)
				return false;
			else
				return true;
		}
		


	}
}
