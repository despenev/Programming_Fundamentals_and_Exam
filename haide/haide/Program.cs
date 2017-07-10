using System;

namespace haide
{
	class MainClass
	{
		public static void Main()
		{
			PrintTriangle(1, 10);
			PrintLine(10);

		}

		public static void PrintTriangle(int num,int num1)
		{
			for (int i = num; i <= num1; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		public static void PrintLine(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				PrintTriangle(1, i);
			}

			for (int j = n - 1; j >= 1; j--)
			{
				PrintTriangle(1, j);
			}
		}



	}
}

