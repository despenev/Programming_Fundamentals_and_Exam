using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Nums
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var digits = new List<int>();
			var list = new List<int>();
			var final = new List<int>();
			var numcopy = 0;

			foreach (var num in nums)
			{
				var umnoj = 1;
				numcopy = num;
				do
				{
					digits.Add(numcopy % 10);
					numcopy = numcopy / 10;
				}
				while (numcopy / 10 > 0);
				for (int k = 1; k < digits.Count; k++)
					{
						umnoj *= 10;
					}
				for (int i = 0; i < digits.Count; i++)
				{
					
					list.Add(digits[i] * umnoj);
					umnoj /= 10;
				}
				final.Add(list.Sum());
				digits.Clear();
				list.Clear();
			}
			Console.WriteLine(final.Sum());
		}
	}
}
