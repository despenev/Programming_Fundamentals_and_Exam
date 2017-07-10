using System;
using System.Linq;
using System.Collections.Generic;

namespace desko
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split('|').ToList();
			var result = new List<int>();
			for (int i = nums.Count-1; i > 0; i--)
			{
				var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
				num.Reverse();
				result.Add(num[i]);
				Console.WriteLine(string.Join(" ",result));
			}
		}
	}
}
