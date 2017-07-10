using System;

namespace Prime_Sieve
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				var count = 0;
				for (int j = 2; j < i; j++)
				{
					if (i % j != 0) count++;
					if (count== i-2) Console.WriteLine(i);
				}
			}
				
				
				
		}
	}
}
