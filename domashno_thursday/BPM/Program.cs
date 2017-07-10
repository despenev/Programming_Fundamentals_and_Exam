using System;

namespace ExactSumofRealNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var acid = new char[5] { 'f', 'A', 'C', 'G', 'T' };

			for (int i = 1; i < 5; i++)
			{
				for (int j = 1; j < 5; j++)
				{
					for (int k = 1; k < 5; k++)
					{
						
						if ( i+j+k == n)
							Console.Write($"O{acid[i]}{acid[j]}{acid[k]}0 ");
						else 
							Console.Write($"X{acid[i]}{acid[j]}{acid[k]}X ");
						
					}
					Console.WriteLine();
				}
			}

		}
	}
}
