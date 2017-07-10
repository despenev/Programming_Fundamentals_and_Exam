using System;
using System.Linq;

namespace Index_of_Letters
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			char[] az = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
			var word = Console.ReadLine().ToCharArray();
			for (int i = 0; i < word.Length; i++)
			{
				for (int letter = 0; letter < az.Length; letter++)
				{
					if ( word[i]==az[letter])
						Console.WriteLine($"{word[i]} -> {letter}");
				}
			}

		}
	}
}
