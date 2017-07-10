using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace S_Nakata
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			File.AppendAllText("output.txt", "hello/n");

			var text = File.ReadAllText("input.txt");
			Console.WriteLine(text);

			Console.WriteLine("hello");
			Console.WriteLine("/n");
			Console.WriteLine("neshto");
			Console.WriteLine("/r");


			// /n= mini na dolen red
			// /r= nalqvo
			// Nakov kaza: zaradi mashinite za pisane!


			byte[] bytes = File.ReadAllBytes("output.txt");
			Console.WriteLine(string.Join(",",
			                              bytes.Select(bytes => string.Format("{0;X}", bytes))));


			var lines = File.ReadAllLines("lines.txt");
			var oddLines = lines.
			                    Where((line, index) => index % 2 !=0);
			Console.WriteLine( );
		}
	}
}
