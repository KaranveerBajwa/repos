using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> lst = null;
			List<string> lst2 = new List<string>();
			//lst.Add("rpt1");
			//lst.Add("rpt2");
			lst2.Add("Hello");
			lst2.AddRange(lst);
	
		}
	}
}
