using System;
using System.Linq;

namespace Arrays
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] arr1 = new int[numbers.Length/2];

				for (int i = 0; i < numbers.Length/4; i++)
				{
					arr1[i] = numbers[numbers.Length / 4 - 1 - i];
					arr1[numbers.Length / 4 + i] = numbers[numbers.Length - 1 - i];
				}
				

			int[] arr2 = new int[numbers.Length / 2];

				for (int i = 0; i < numbers.Length/2; i++)
				{
					arr2[i] = numbers[numbers.Length / 4 + i];
				}

				for (int i = 0; i < numbers.Length/2; i++)
				{
					Console.Write($"{arr1[i]+arr2[i]} ");
				}
		}
	}
}
