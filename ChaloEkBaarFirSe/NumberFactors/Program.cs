using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFactors
{
	class Program
	{
		static void Main(string[] args)
		{
			var res = NumFactors(5);
		}

		static int NumFactors(int n)
		{
			int[] factors = new int[n + 1];
			factors[0] = 1;
			for (int i = 1; i < factors.Length; i++)
			{
				int minus1 = factors[i - 1];
				int minus3 = (i - 3) >= 0 ? factors[i - 3] : 0;
				int minus4 = (i - 4) >= 0 ? factors[i - 4] : 0;
				factors[i] = minus1 + minus3 + minus4;
			}
			return factors[n];
		}
	}
}
