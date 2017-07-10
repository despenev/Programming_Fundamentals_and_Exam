using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx_Lab_Nakov
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
			var matches  = Regex.Matches(text, pattern);

			foreach (Match name in matches)
			{
				Console.Write(name + " ");
			}
		}
	}
}
