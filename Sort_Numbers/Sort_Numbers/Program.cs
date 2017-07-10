using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort_Numbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
			numbers.Sort();
			for (int i = 0; i < numbers.Count; i++)
			{
				if (i != numbers.Count - 1) Console.Write($"{numbers[i]} <= ");
				else Console.Write(numbers[i]);
			}


		}
	}
}
