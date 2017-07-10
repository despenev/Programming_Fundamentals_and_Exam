using System;

namespace Exception_Naka
{
	class MainClass
	{
		private static int ReadCorrectNum()
		{
			while (true)
			{
				try
				{
					return int.Parse(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Incorrect");
				}
			}
		}

		public static void Main(string[] args)
		{

			try
			{
				var num1 = ReadCorrectNum();
					var num2 = ReadCorrectNum();
				Console.WriteLine("Mult = " + num1 * num2);
			}
			catch { Console.WriteLine("Error reading nums"); }
		}
	}
}
