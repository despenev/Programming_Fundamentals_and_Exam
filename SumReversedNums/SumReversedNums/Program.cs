using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNums
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var sum = 0;

			for (int i = 0; i < nums.Count; i++)
			{
				var reversed = 0;

				while (nums[i] > 0)
				{
					var r = nums[i] % 10;
					reversed = reversed * 10 + r;
					nums[i] = nums[i] / 10;
				}
				sum += reversed;
			}
			Console.WriteLine(sum);
		}
	}
}
