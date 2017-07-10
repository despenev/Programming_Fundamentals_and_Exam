using System;

namespace Matrix_Letters
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var r = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());
			//var matrix = new char[r,c];
			char letter = 'A';
			for (int row = 0; row < r; row++)
			{
				for (int col = 0; col < c; col++)
				{
					//matrix[row, col] = letter;
					Console.Write(letter+ " ");
					letter++;
				}
				Console.WriteLine();
			}
		}
	}
}
