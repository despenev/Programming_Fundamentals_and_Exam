using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] driversNames = Console.ReadLine().Split();
			double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
			double[] checkpoints = Console.ReadLine().Split().Select(double.Parse).ToArray();

			foreach (var driver in driversNames)
			{
				double fuel = (int)driver[0];
				int counter = 0;

				for (int i = 0; i < zones.Length; i++)
				{
					bool equal = false;
					for (int j = 0; j < checkpoints.Length; j++)
					{
						if (i == checkpoints[j])
						{
							equal = true;
							break;
						}
					}
					if (equal)
					{
						fuel += zones[i];
					}
					else
					{
						fuel -= zones[i];
					}

					if (fuel > 0)
					{
						counter++;
					}
					else
					{
						Console.WriteLine($"{driver} - reached {counter}");
						break;
					}
				}
				if (fuel > 0)
				{
					Console.WriteLine($"{driver} - fuel left {fuel:f2}");
				}
			}
		}
	}
}