using System;

namespace matrica
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			for (int row = 1; row <= n; row++)
			{
				Desko(row);
			}
			for (int row = n-1; row >=1; row--)
			{
				Desko(row);
			}
		}

		public static void Desko(int row)
		{
			
			for (int col = 1; col <= row; col++)
			{
				Console.Write(col + " ");
			}
			Console.WriteLine();
		}
			
	}
}
