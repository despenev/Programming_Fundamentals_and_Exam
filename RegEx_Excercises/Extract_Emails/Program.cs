using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var pattern = new Regex(@"(?<=\s)[a-z0-9]+([-\._]\w*)*@[a-zA-Z0-9]+([\.-][a-zA-Z0-9]+)*\.[a-zA-Z0-9]+");
			var text = Console.ReadLine();

			var emails = pattern.Matches(text);

			foreach (Match email in emails)
			{
				Console.WriteLine(email);
			}
		}
	}
	

}
