using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyCoreProject.Models
{
	public class Hi
	{
		public string SayHi => "Hi" + Name;
		public string Name { get; set; } = "John";
	}
}
