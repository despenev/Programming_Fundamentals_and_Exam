using System;
using System.Linq;

namespace Pairs_of_Difference
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var diff = int.Parse(Console.ReadLine());
			var pairs = 0;
			for (int left = 0; left < num.Length; left++)
			{
				for (int right = 0; right <num.Length; right++)
				{
					if (num[right] - num[left] == diff) pairs++;
				}
			}
			Console.WriteLine(pairs);
		}

	}
}
