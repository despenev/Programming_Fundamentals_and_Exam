using System;

namespace Prime_Sieve_Bool
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			bool[] primes = new bool[n+1];
				for (int i = 0; i <= n; i++)
			{
				primes[i] = true;
			}

			primes[0] = primes[1] = false;

			for (int i = 2; i <= n; i++)
			{
				if (primes[i] == true) 
				{
					Console.WriteLine(i);
					for (int j = 2; j<= n/i ; j++)
					{
						primes[j*i] = false;
					}
				}
			}


		}
	}
}
