using System;
using System.Collections.Generic;
using System.Linq;


namespace Population_Counter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var dict = new Dictionary<string, Dictionary<string, int>>();
			while (true)
			{
				var input = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if (input[0] == "report")
				{
					foreach (var Country in dict)
					{
						int totalP = 0;
						foreach (var City in Country.Value)
						{
							totalP += City.Value;
						}
						Console.WriteLine(Country.Key + $" (total population: {totalP})");
						foreach (var City in Country.Value)
						{
							Console.WriteLine($"=>{City.Key}: {City.Value}");
						}
					}
					return;
				}
				var city = input[0];
				var country = input[1];
				int population = int.Parse(input[2]);


				if (!dict.ContainsKey(country))
				{
					dict[country] = new Dictionary<string, int>();
				}
				if (!dict[country].ContainsKey(city))
				{
					dict[country][city] = 0;
				}
				dict[country][city] += population;


			}
		}
	}
}

