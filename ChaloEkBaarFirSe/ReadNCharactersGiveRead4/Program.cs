using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNCharactersGiveRead4
{
	class Program
	{
		static void Main(string[] args)
		{
      char[] buf = new char[10];
      Read(buf, 4);
		}

    public static int Read(char[] buf, int n)
    {
      int runningCount = 0;
      char[] temp = { 'a', 'b', 'c' };
      while (runningCount <= n)
      {
        int readCount = 3;

        for (int i = 0; runningCount < n && i < readCount; i++, ++runningCount)
        {
          buf[runningCount] = temp[i];
        }
      }
      return runningCount;
    }
  }
}
