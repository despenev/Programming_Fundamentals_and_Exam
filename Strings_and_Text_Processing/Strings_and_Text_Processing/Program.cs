using System;
using System.Linq;
using System.Collections.Generic;

namespace Strings_and_Text_Processing
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var text = Console.ReadLine().ToLower();
			var word = Console.ReadLine().ToLower();
			var count = 0;
			var lastindex = -1;
			while (true)
			{
				var index = text.IndexOf(word,lastindex+1);
				if (index != -1) 
				{
					count++;
					lastindex = index;
				}
				else break;

			}
			Console.WriteLine(count);


		}
	}
}
