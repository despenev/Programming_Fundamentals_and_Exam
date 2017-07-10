using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_Group
{
	class MainClass
	{
		public class Student
		{
			public List<string> Comments { get; set; }
			public List<DateTime> Attendance { get; set; }
		}

		public static void Main(string[] args)
		{
			var students = new Dictionary<string, Student>();

			while (true)
			{
				var tokens = Console.ReadLine().Split(new char[] { ' ', ',' }).ToList();

				if (tokens[0]=="end")    //////////////////////////////////// ================= ei tuka moje da ima bug, ako nqkoi se kazva "end"
				{
					break;
				}

				var name = tokens[0];

				var attendance = new List<DateTime>();
				foreach (var date in tokens.Skip(1))
				{
					attendance.Add( DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
				
				}
				if (!students.ContainsKey(name))
				{
					students[name] = new Student()
					{
						Attendance = attendance,
						Comments = new List<string>()
					};
				}
				else 
				{
					students[name].Attendance.AddRange(attendance);
				}

			}



			while (true)
			{
				var tokens = Console.ReadLine().Split('-').ToList();

				if (tokens[0]=="end of comments")
				{
					foreach (KeyValuePair<string,Student> student in students.OrderBy(x=>x.Key))
					{
						Console.WriteLine($"{student.Key} \nComments:");

						foreach (var comment in student.Value.Comments)
						{
							Console.WriteLine($"- {comment}");

						}


						Console.WriteLine("Dates attended:");

						foreach (var date in student.Value.Attendance.OrderBy(x=>x))
						{
							Console.WriteLine($"-- {date:dd/MM/yyyy}");
						}

					}
					return;
				}

				var name = tokens[0];

				if (students.ContainsKey(name))
				{
					var comment = tokens[1];
					students[name].Comments.Add(comment);
				}
			}
		}
	}
}
