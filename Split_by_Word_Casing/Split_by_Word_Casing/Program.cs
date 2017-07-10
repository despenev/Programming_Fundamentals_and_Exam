using System;
using System.Linq;
using System.Collections.Generic;
namespace Split_by_Word_Casing
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var separators = new char[]
			{
				',', ';',  ':', '.',  '!',  '(', ')', '\\', '/', '[', ']',' ','"','\''
			};
			var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
			var upperCase = new List<string>();
			var lowerCase = new List<string>();
			var mixedCase = new List<string>();
			foreach (var word in words)
			{
				var type = GetWordType(word);
				if (type == WordType.lowerCase) lowerCase.Add(word);
				else if (type == WordType.upperCase) upperCase.Add(word);
				else mixedCase.Add(word);
			}
			Console.WriteLine("Lower-case: {0}",string.Join(", ", lowerCase));
			Console.WriteLine("Mixed-case: {0}",string.Join(", ", mixedCase));
			Console.WriteLine("Upper-case: {0}",string.Join(", ", upperCase));

		}
		enum WordType { lowerCase, upperCase, mixedCase }
		static WordType GetWordType(string word)
		{
			var lowerLetters = 0;
			var upperLetters = 0;
			foreach (var letter in word)
			{
				if (char.IsUpper(letter)) upperLetters++;
				else if (char.IsLower(letter)) lowerLetters++;
			}
			if (lowerLetters == word.Length) return WordType.lowerCase;
			else if (upperLetters == word.Length) return WordType.upperCase;
			else return WordType.mixedCase;
		}
}
}
