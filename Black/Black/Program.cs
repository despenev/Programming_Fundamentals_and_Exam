using System;

namespace Black
{
	class MainClass
	{
		public static void Main()
		{
			Method("Gabriella", 20, true);
		}
		public static void Method(string name, int num, bool n)
		{
			if (n)
			{
				Console.WriteLine($"My name is: {name}.I am {num} years old.Yes!");
			}
			else
			{
				Console.WriteLine($"My name is: {name}.I am {num} years old.No!");
			}
		}
	}
}