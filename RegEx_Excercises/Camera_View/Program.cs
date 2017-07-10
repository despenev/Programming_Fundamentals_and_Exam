using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Camera_View
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var mn = Console.ReadLine().Split().ToList();
			var m = int.Parse(mn[0]);
			var n = int.Parse(mn[1]);

			var text = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			var wordList = new List<string>();

			for (int i = 0; i < text.Count; i++)
			{
				var test = text[i].ToCharArray();
				var end = new List<char>();
				if (test[0] == '<')
				{
					if (m + n <= test.Length)
					{
						if (m != 0 && m + n < test.Length)
						{
							for (int j = 1 + m; j <= m + n; j++)
							{
								end.Add(test[j]);
							}
						}
						else if (m != 0 && m + n == test.Length)
						{
							for (int j = 1 + m; j < m + n; j++)
							{
								end.Add(test[j]);
							}
						}
						else
						{
							for (int j = 1; j <= n; j++)
							{
								end.Add(test[j]);
							}
						}
						var word = string.Join("", end);
						wordList.Add(word);

					}
				}

			}

			Console.WriteLine(string.Join(", ", wordList));



		}
	}
}

