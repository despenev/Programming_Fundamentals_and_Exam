using System;
using System.Linq;

namespace Most_Frequent_Number_2nd
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var count = 1;
			var check = 0;
			var maxcount = 1;
			var pos = 0;

			for (int num = 0; num < numbers.Length; num++)
			{
				for (int right = num +1; right < numbers.Length; right++)
				{
					if (numbers[num] == numbers[right])
					{
						for (int left = 0; left < num; left++)
						{
							if (numbers[num] != numbers[left]) check++;
						}
						if (check == num) count++;
						if (count > maxcount)
						 	{
								maxcount = count;
							pos = num;
							}
					}
					check = 0;
				}
				count = 1;

			}

				Console.Write(numbers[pos]);
			
		}
	}
}
