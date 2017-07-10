using System;
using System.Collections.Generic;
using System.Linq;
namespace AVG_grade_vladi
{
	class MainClass
	{
		class Student 
		{
			public string Name
			{
				get;
				set;
			}
			public List<double> Grades
			{
				get;
				set;
			}

			public double AverageGrade => Grades.Average();
		}
		public static void Main(string[] args)
		{
			var studentsCount = int.Parse(Console.ReadLine());
			var students = new List<Student>();
			for (int i = 0; i < studentsCount; i++)
			{
				var tokens = Console.ReadLine().Split();
				var name = tokens.First();
				var grades = tokens.Skip(1).Select(double.Parse).ToList();
				var student = new Student
				{
					Name = name,
					Grades = grades
				};
				students.Add(student);

			}

			students = students
							   .Where(a => a.AverageGrade >= 5.00)
							   .OrderBy(a => a.Name)
							   .ThenByDescending(a => a.AverageGrade)
							   .ToList();

			foreach (var student in students)
			{
				Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
			}
		}
	}
}
