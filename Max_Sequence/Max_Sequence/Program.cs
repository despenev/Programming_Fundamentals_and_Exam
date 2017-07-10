using System;
using System.Linq;

namespace Max_Sequence
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var start = 0;
			var len = 1;
			var bestStart = 0;
			var bestLen = 0;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] == numbers[i - 1])
				{
					len++;

				}

				else 
				{
					len = 1;
					start = i;
				}

				if (len > bestLen)
				{
					bestLen = len;
					bestStart = start;
				}

			}
			for (int i = 0; i < bestLen; i++)
			{
				Console.Write(numbers[bestStart] + " " );
			}


		}
	}
}
