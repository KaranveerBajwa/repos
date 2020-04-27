using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.BL
{
	public class Product
	{
		public int Id { get;  }
		public string Name { get; set; }
		public string Desription { get; set; }
		public Decimal CurrentPrice { get; set; }

		public Product Retrieve()
		{
			return null;
		}

		public void Validate()
		{
		}

		public void Save()
		{
		}
	}
}
