using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Methods_and_Debugging
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int jump = int.Parse(Console.ReadLine());

			bool hasMatch = false;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'p')
				{
					hasMatch = true;



					if (jump +1> text.Length-i)
					{
						jump = text.Length-1-i;
					}

					string matchedString = text.Substring(i, jump+1);
					Console.WriteLine(matchedString);
					i += jump;
				}
			}

			if (!hasMatch)
			{
				Console.WriteLine("no");
			}
		}

	}
}