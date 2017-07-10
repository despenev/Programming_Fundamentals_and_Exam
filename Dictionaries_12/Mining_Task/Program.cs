using System;
using System.Collections.Generic;
using System.Linq;

namespace Mining_Task
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var invertory = new Dictionary<string, int>();
			while (true) 
			{
				var material = Console.ReadLine();
				if (material == "stop") 
				{
					foreach (var item in invertory)
					{
						Console.WriteLine($"{item.Key} -> {item.Value}");
					}
					return;
				}
				var quantity = int.Parse(Console.ReadLine());

				if (invertory.ContainsKey(material))
					invertory[material]+=quantity;
				else invertory[material] = quantity;

			}
		}
	}
}
