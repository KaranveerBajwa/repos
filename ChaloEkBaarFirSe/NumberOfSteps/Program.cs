using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWaysToTop
{
	class Program
	{
		static void Main(string[] args)
		{
			int res = NumberOfWays(8);
		}

		public static int NumberOfWays(int top)
		{
			int[] numWays = new int[top + 1];
			numWays[0] = 1;
			for (int i = 1; i < numWays.Length; i++)
			{
				int minus1 = numWays[i - 1];
				int minus3 = (i - 3) >= 0 ? numWays[i - 3] : 0; 
				int minus5 =	 (i - 5) >= 0 ? numWays[i - 5] : 0;
				numWays[i] = minus1 + minus3 + minus5;
			}
			return numWays[top];
		}

	}
}
