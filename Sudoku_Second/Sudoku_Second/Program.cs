using System;

namespace Sudoku_Second
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			{
				int[,] sudoku = new int[9, 9];
				for (int row = 0; row < 9; row++)
				{
					for (int col = 0; col < 9; col++)
					{
						sudoku[row, col] = int.Parse(Console.ReadLine());

					}
				}
			}
		}
		private bool box(int row, int col, int[,] sudoku)
		{
			int startRow = row / 3 * 3;
			int startCol = col / 3 * 3;

			for (int i = startRow; i < startRow + 3; i++)
			{
				for (int j = startCol; j < startCol + 3; j++)
				{
					if (row != i && col != j)
					{
							if (sudoku[row,col] != sudoku[i,j]) return true;
					}

				}

			}
			return false;
		}
		}
	}
}
