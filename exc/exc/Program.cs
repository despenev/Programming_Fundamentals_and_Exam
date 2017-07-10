using System;
using System.Linq;
using System.Collections.Generic;

namespace exc
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var d1 = int.Parse(Console.ReadLine());
			var d2 = int.Parse(Console.ReadLine());
			var magic = int.Parse(Console.ReadLine());


			var counter = 0;
			var list = new List<int>();

			for (int i = d1; i <= d2; i++)
			{
				for (int k = d1; k <= d2; k++)
				{
					counter++;
					if (i + k == magic)
					{
						list.Add(i);
						list.Add(k);
						if (i == d2 && k == d2)
						{
							Console.WriteLine($"Number found! {list[list.Count - 2]} + {list[list.Count - 1]} = {magic}");
						}
					}
					if (i + k != magic && i == d2 && k == d2)
					{
						Console.WriteLine($"{counter} combinations - neither equals {magic}");
					}
				}
			}
		}
	}


}

