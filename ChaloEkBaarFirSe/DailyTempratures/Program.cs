using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTempratures
{
	class Program
	{
		static void Main(string[] args)
		{
      int[] arr = { 73,74,75,71,69,72,76,73};
      var res = dailyTemperatures(arr);
		}

      public static int[] dailyTemperatures(int[] T)
      {
        int[] ans = new int[T.Length];
        int[] next = new int[101];
      for (int i = 0; i < next.Length; i++)
      {
        next[i] = Int32.MaxValue;
      }
         
        for (int i = T.Length - 1; i >= 0; --i)
        {
          int warmer_index = Int32.MaxValue;
          for (int t = T[i] + 1; t <= 100; ++t)
          {
            if (next[t] < warmer_index)
              warmer_index = next[t];
          }
          if (warmer_index < Int32.MaxValue)
            ans[i] = warmer_index - i;
          next[T[i]] = i;
        }
        return ans;
      }
 





  }
}
