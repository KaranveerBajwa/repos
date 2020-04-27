using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnglesOfClock
{
	class Program
	{
		static void Main(string[] args)
		{
			double angle = AnglesOfClock(3, 15);
			Console.WriteLine(angle);
			Console.ReadKey();
		}

		public static double AnglesOfClock(int hour, int minutes)
		{
			double minuteAngle = minutes * (360/60);
			double hourAngle = (360 / 12) * hour + (30.0 / 60) * minutes;
			double diff = Math.Abs(hourAngle - minuteAngle);
			return diff;

		}
	}
}
