using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkList ll = new LinkList();
			ll.Append(3);
			ll.Append(5);
			ll.Append(8);
			ll.Append(5);
			ll.Append(10);
			ll.Append(8);
			ll.Append(3);
			ll.Append(2);
			var res= _2_1RemoveDups.RemoveDups(ll.head);
		}
	}
}
