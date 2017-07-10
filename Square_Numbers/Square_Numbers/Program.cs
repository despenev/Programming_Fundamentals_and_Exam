using System;
using System.Linq;
using System.Collections.Generic;

namespace Square_Numbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var squares = new List<int>();
			foreach (var number in numbers)
			{
				var type = GetSquareValue(number);
				if (type == IsSquare.square) squares.Add(number);
			}
			squares.Sort();
			squares.Reverse();
			for (int i = 0; i < squares.Count; i++)
			{
				Console.Write($"{squares[i]} ");
			}
		}
		enum IsSquare { square,no};
		static IsSquare GetSquareValue(int number)
		{
			for (int i = 1; i <=number/i; i++)
			{
				if (i * i == number) return IsSquare.square;
			}
			return IsSquare.no;
		}
}
}
