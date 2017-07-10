using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Unicode_Characters
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string word = Console.ReadLine();

			var chars = word.Select(c => (int)c).Select(c => $@"\u{c:x4}");
			var result = string.Concat(chars);
			Console.WriteLine(result);
		}
	}
}
