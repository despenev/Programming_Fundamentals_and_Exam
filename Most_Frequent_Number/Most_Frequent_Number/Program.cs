using System;
using System.Linq;
namespace Most_Frequent_Number
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var count = 1;
			var chek = 0;
			var maxcount = 1;
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = 0; j < numbers.Length - i; j++)
				{
					for (int k = 0; k <= i; k++)
						{
							if (numbers[i] == numbers[j] && numbers[i] != numbers[k])
							{
								chek++;
								if (chek == i + 1) count++;
							}
						}
					
				}
				if (count > maxcount) maxcount = count;
			}
			Console.WriteLine(count);
		}
	}
}
