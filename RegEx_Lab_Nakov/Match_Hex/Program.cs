using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Match_Phonenumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"\b(?:0x)?[0-9A-F]+\b";
			var matches = Regex.Matches(text, pattern);


			var matchedPhones = matches.
									   Cast<Match>().
									   Select(a => a.Value.Trim()).
									   ToArray();

			Console.WriteLine(string.Join(" ", matchedPhones));
		}
	}
}

