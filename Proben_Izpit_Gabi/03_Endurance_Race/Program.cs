using System;
using System.Collections.Generic;
using System.Linq;


namespace _Endurance_Race
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Distinct();


			var zones = Console.ReadLine().Split().Select(decimal.Parse).ToList();



			var checkpoints = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

			for (int i = 0; i < checkpoints.Count; i++)  // eituka ima neshto??
			{
				try
				{
					zones[checkpoints[i]] = -zones[checkpoints[i]];
				}
				catch (System.ArgumentOutOfRangeException) { continue; }
			}




			foreach (var name in names)
			{

				var fuel = (decimal)(name.First());

				for (int zone = 0; zone < zones.Count; zone++)
				{
					if (fuel > 0)
					{
						fuel -= zones[zone];

					}
					if (fuel <= 0)
					{
						Console.WriteLine($"{name} - reached {zone}");
						break;
					}
				}

				if (fuel > 0)
				{
					Console.WriteLine($"{name} - fuel left {fuel:f2}");
				}
			}

		}
	}
}

