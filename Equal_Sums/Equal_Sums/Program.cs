using System;
using System.Linq;
namespace Equal_Sums
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var rotatenum = int.Parse(Console.ReadLine());
			var sum = new int[arr.Length];

			for (int i = 0; i < rotatenum; i++)
			{
				for (int r = 0; r < arr.Length; r++)
				{
					//var last = arr[arr.Length - 1];
					arr[r] = arr[r + 1];
					//arr[0] = last;
				}
			}


		}
	}
