using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings_and_Text_Processing_Excercises_Vladi
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split();
			var @base = int.Parse(numbers[0]);
			var num = BigInteger.Parse(numbers[1]);
			List<int> digits = new List<int>();

			var result = new StringBuilder;
			while (num>0)
			{
				var remainder = (int)num % @base;

				num/=@base;

				digits.Add(remainder);
				result.Append(remainder);
			}


			var reversedResult = new string 
		}
	}
}
