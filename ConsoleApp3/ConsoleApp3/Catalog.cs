using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	public class Catalog : ISavable
	{
		void ISavable.Save()
		{
			Console.WriteLine("Catalog is saved");
		}

		public void Save()
		{
			Console.WriteLine("Independent method");
		}
	}
}
