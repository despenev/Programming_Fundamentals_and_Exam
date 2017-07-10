using System;
using System.Linq;

namespace Max_Sequence_of_Increasing_Elements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var len = 1;
			var start = 0;
			var bestLen = 0;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] > numbers[i - 1]) { len++; }
				else { len = 1; }
				if (len > bestLen) { bestLen = len; start = i+1 - len;  }
			}

			for (int i = start; i < start+bestLen; i++)
			{
				Console.Write(numbers[i] + " ");
			}
		}

	}
}
