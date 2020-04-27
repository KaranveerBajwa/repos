using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWordsIntoAnagrams
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = { "abc", "cba" };
			
			Hashtable ht = new Hashtable();
			bool[] bits = new bool[26];
			foreach (char c in arr[0])
			{
				bits[c - 'a'] = true;
			}
			var result = bits.ToHashSet();
			bits = new bool[26];
			foreach (char c in arr[1])
			{
				bits[c - 'a'] = true;
			}
			var results1 = bits.ToHashSet();
			if (result == results1)
				Console.WriteLine("I am in");
			else
				Console.WriteLine("Some issues here");

		}
	}
}
