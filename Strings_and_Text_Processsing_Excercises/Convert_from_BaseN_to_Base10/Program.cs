using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace Convert_from_BaseN_to_Base10
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			var usedBase = int.Parse(input[0]);
			var numBase = BigInteger.Parse(input[1]);
			var nums = new List<BigInteger>();
			if (usedBase >= 2 && usedBase <= 10)
			{
				while (numBase > 0)
				{
					nums.Add(numBase % 10);
					numBase /= 10;
				}


				BigInteger result = 0;

				for (int i = 0; i < nums.Count; i++)
				{
					if (i == 0) { result += nums[i]; }
					else
					{
						var baseMultiply = 1;


						for (int j = 1; j <= i; j++)
						{
							baseMultiply = baseMultiply * usedBase;
						}
						result += nums[i] * baseMultiply;
					}
				}

				Console.WriteLine(result);

			}
			else
			{
				Console.WriteLine(0);
			}
		}
	}
}
