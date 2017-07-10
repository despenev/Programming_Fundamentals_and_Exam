using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


namespace cukane_s_nakov
{


	class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
	};

	class MainClass
	{
		public static void Main(string[] args)
		{
			var birthday = new
			{
				day = 12,
				month = 11,
				year = 1997
			};
			Console.WriteLine(birthday);

			var day = new DateTime(2017, 9, 9);
			Console.WriteLine(day);

			var s = new string('a', 10);
			Console.WriteLine(s);

			DateTime Bushi = new DateTime(1997, 3, 30);
			DateTime Desko = new DateTime(1996, 5, 29);

			var diff = Bushi.Subtract(Desko);
			Console.WriteLine(diff);

			//string dateAsText = Console.ReadLine();
			//DateTime date = DateTime.Parse(dateAsText, "d-M-yyyy");


			var randGen = new Random();
			Console.WriteLine(randGen.Next(100, 200));

			//randomize words

			string[] words = Console.ReadLine().Split(' ');
			Random rnd = new Random();
			for (int pos1 = 0; pos1 < words.Length; pos1++)
			{
				int pos2 = rnd.Next(words.Length);
				var old = words[pos1];
				words[pos1] = words[pos2];
				words[pos2] = old;
			}
			Console.WriteLine(string.Join("\r\n", words));

			Student p = new Student[]
			{
				new Student() {Name="Gabi", Age=20}
			 	new Student() { Name = "Desko", Age = 21 }
			};


		
				}

		}
	}
