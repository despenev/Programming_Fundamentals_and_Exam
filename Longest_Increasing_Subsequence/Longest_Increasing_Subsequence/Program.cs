using System;
using System.Linq;
using System.Collections.Generic;

namespace Longest_Increasing_Subsequence
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var currentSub = new List<int>();
			var bestSub = new List<int>();
			currentSub.Add(numbers[0]);
			for (int i = 1; i < numbers.Count; i++)
			{
				for (int j= i; j < numbers.Count; j++)
				{
					if (currentSub[currentSub.Count-1]< numbers[j])
				 	{
						for (int m = j; m < numbers.Count; m++)
						{

						}
						currentSub.Add(numbers[j]);

					{
						currentSub[currentSub.Count - 1] = numbers[j];
					}
					}

					if (currentSub.Count > bestSub.Count) 
					{
						bestSub = new List<int>();
						for (int k = 0; k < currentSub.Count; k++)
						{
							bestSub.Add(currentSub[k]);
						}
					}
				}
				currentSub = new List<int>();
				currentSub.Add(numbers[i]);
				
			}
			for (int i = 0; i < bestSub.Count; i++)
			{
				Console.Write(bestSub[i] + " ");
			}

		}
	}
}
