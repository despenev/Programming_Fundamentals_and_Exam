using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Numbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			numbers.Sort();
			var count = 1;
			var pos = 0;
			while (pos < numbers.Count) 
			{
				int num = numbers[pos];
				count = 1;
				while (pos + count < numbers.Count && numbers[pos + count] == num) 
				{
					count++;
				}
				pos = pos + count;
				Console.WriteLine($"{num} -> {count}");
			}




		}
	}
}
