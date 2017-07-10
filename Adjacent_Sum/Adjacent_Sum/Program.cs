using System;
using System.Linq;
using System.Collections.Generic;

namespace Adjacent_Sum
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
			for (int i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] == numbers[i - 1])
				{
					numbers[i - 1] += numbers[i];
					numbers.RemoveAt(i);
					i -= 2;
						if (i == -1) i++;
				}
			
			}
			for (int i = 0; i < numbers.Count; i++)
			{
				Console.Write(numbers[i]+ " ");
			}
		}
	}
}
