using System;
using System.Collections.Generic;
using System.Linq;


namespace Average_Grades
{
	class MainClass
	{
		class Student
		{
			public string Name { get; set; }
			public List<double> Grades { get; set; }
			public double Average => Grades.Average();

			public static void Main(string[] args)
			{
				int n = int.Parse(Console.ReadLine());
				var students = new List<Student>();

				for (int i = 0; i < n; i++)
				{
					var input = Console.ReadLine().Split().ToList();
					var grades = input.Skip(1).Select(double.Parse).ToList();




					var student = new Student
					{
						Name = input[0],
						Grades = grades,


					};
					students.Add(student);


				}
				students = students.
								  Where(x => x.Average >= 5.0).
								  OrderBy(x => x.Name).
								   ThenByDescending(x => x.Grades).
								   ToList();
				foreach (var student in students)
				{
					Console.WriteLine($"{student.Name} -> {student.Average:f2}");
				}



			}
		}
	}
}
