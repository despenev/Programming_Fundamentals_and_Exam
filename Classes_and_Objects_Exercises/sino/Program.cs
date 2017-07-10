using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace sino
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

			var steps2home = int.Parse(Console.ReadLine());
			var secPerStep = int.Parse(Console.ReadLine());

			var totalSec = steps2home * secPerStep;

			var timeHome = time.AddSeconds(totalSec);

			Console.WriteLine($"{timeHome:hh:mm:ss}");


		}
	}
}
