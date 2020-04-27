using System;

namespace FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			SimpleFactory sf = new SimpleFactory();
			var res  = sf.CreatePizza("Cheese");
		}
	}
}
