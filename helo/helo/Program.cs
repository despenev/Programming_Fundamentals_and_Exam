using System;

namespace helo
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var max = int.Parse(Console.ReadLine());
			var min = int.Parse(Console.ReadLine());
			var magic = int.Parse(Console.ReadLine());
			var comb = 0;



			for (int first = max; first >= min; first--)
			{
				

				for (int second = max; second >= min; second--)
				{
					comb++;
					if (first + second == magic)
					{
						Console.WriteLine($"Combination N: {comb} ({first} + {second} = {magic})");
						return;
					}
				}
			}

			Console.WriteLine($"{comb} - neither equals {magic}");
		}
	}
}
