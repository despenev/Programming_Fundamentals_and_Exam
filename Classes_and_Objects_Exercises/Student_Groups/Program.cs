using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace Student_Groups
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		class Student
		{
			public string Name { get; set; }
			public string Email { get; set; }
			public DateTime RegistrationDate { get; set;}
		}

		class Town
		{
			public string Name { get; set; }
			public int SeatsCount { get; set; }
			public List<Student> StudentsListTown { get; set; }
		}

		class Group
		{
			public Town Town { get; set; }
			public List<Student> StudentsListGroup { get; set; }
		}
		static List<Town> ReadTownsAndStudents()
		{
			var towns = new List<Town>();

			while (true)
			{
				var tokens = Console.ReadLine().Split(new char[] {' ', '|'},StringSplitOptions.RemoveEmptyEntries)
			}
			return towns;
		}

	}
}


