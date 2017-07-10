using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Extract_Sentences_by_Keyword
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var keyWord = Console.ReadLine();
			var pattern = new Regex($@"\b{keyWord}\b");
			var text = Console.ReadLine().Split('.', '?', '!').ToList();

			var matchedText = new List<string>();

			foreach (var sentence in text)
			{
				var match = pattern.Match(sentence);
				if (match.Success == true)
				{
					matchedText.Add(sentence);
				}
			}

			foreach (var sentence in matchedText)
			{
				Console.WriteLine(sentence);
			}



		}
	}
}
