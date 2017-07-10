using System;
using System.Linq;
using System.Collections.Generic;

namespace TextFilter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			var text = Console.ReadLine();

			foreach (var word in bannedWords)
			{
				if (text.Contains(word)) 
				{
					text = text.Replace(word, new string('*', word.Length));
				}
			}
			Console.WriteLine(text);
		}

	}
}
