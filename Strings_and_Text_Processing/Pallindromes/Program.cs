using System;
using System.Linq;
using System.Collections.Generic;

namespace Pallindromes
{
	class MainClass
	{
		static List<string> IsPallindrome(List<string> input)
		{
			var output = new List<string>();
			foreach (var word in input)
			{
				var count = 0;
				for (int i = 0; i < word.Length/2; i++)
				{
					if (word.Length == 1)
						output.Add(word);
					if (word[i] == word[word.Length - 1 - i])
					{
						count++;
					}
					else break;
				}
				if (count==word.Length/2)
				{
					output.Add(word);
				}
			}

			return output;
		}
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {',','.','?','!','/',' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Distinct().OrderBy(a => a).ToList();
			var output = IsPallindrome(input);
			Console.WriteLine(string.Join(", ", output));

		}
	}
}
