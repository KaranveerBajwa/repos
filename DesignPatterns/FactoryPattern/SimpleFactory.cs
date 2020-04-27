using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public class SimpleFactory
	{
		public Pizza CreatePizza(string type)
		{
			Pizza pizza;
			if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
			{
				pizza = new CheesePizza();
			}
			else if (type.Equals("greek", StringComparison.OrdinalIgnoreCase))
			{
				pizza = new GreekPizza();
			}
			else
				pizza = new RegularPizza();
			return pizza;
		}
	}
}
