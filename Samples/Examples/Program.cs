
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
	class Program
	{
		static void Main(string[] args)
		{
			char c = '3';
			bool i = Char.IsNumber(c);
			int c11 = c - '0';

			string s = "54";
			bool res = Int32.TryParse(s, out int result);

			Dictionary<char, int> precedence = new Dictionary<char, int>();
			precedence.Add('+', 2);
			precedence.Add('-', 2);
			precedence.Add('*', 1);
			precedence.Add('/', 1);
			if (precedence.ContainsKey('@'))
			{
				var c2 = precedence['@'];
			}
		}
	}
}
