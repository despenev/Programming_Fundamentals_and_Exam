using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_sequence_of_equal_elements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var initial = Console.ReadLine().Split().Select(int.Parse).ToList();

			var command = Console.ReadLine().Split().Select(int.Parse).ToList();

			var take = command[0];

			for (int i = take; i < initial.Count; i++)
			{
				initial.RemoveAt(i);
			}
			for (int i = command[1]-1; i >=0; i--)
			{
				
				initial.RemoveAt(i);

			}
			if (initial.Contains(command[2]))
				Console.WriteLine("YES!");
			else
				Console.WriteLine("NO!");
			    

		}
	}
}
