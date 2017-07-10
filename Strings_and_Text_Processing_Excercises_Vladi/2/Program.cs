using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
var numbers = Console.ReadLine().Split();
var @base = int.Parse(numbers[0]);
			var num = numbers[1].Reverse().ToArray();

			var sum = new StringBuilder();

			for (int power = 0; power< num.Length; power++)
			{
				var currentNum = int.Parse(num[power].ToString());
				sum = +currentNum * BigInteger.Pow(@base, power);
			}

		}
	}
}
