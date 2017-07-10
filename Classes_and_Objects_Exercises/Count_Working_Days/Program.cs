using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Count_Working_Days
{
	class MainClass
	{
		class Holidays
		{

		}
		public static void Main(string[] args)
		{
			var startDateText = Console.ReadLine();
			var endDateText = Console.ReadLine();
			DateTime startDate = DateTime.ParseExact(startDateText."dd-MM-yyyy", CultureInfo.InvariantCulture);
			DateTime endDate = Convert.ToDateTime(endDateText);

			DateTime[] holidays = new DateTime[11];

			holidays[0] = new DateTime(4, 01, 01);
			holidays[1] = new DateTime(4, 03, 03);
			holidays[2] = new DateTime(4, 05, 01);
			holidays[3] = new DateTime(4, 05, 06);
			holidays[4] = new DateTime(4, 05, 24);
			holidays[5] = new DateTime(4, 09, 06);
			holidays[6] = new DateTime(4, 09, 22);
			holidays[7] = new DateTime(4, 11, 01);
			holidays[8] = new DateTime(4, 12, 24);
			holidays[9] = new DateTime(4, 12, 25);
			holidays[10] = new DateTime(4, 12, 26);

			int workingDayCounter = 0;

			for (DateTime i = startDate; i <= endDate; i.AddDays(1))
			{
				DayOfWeek day = i.DayOfWeek;

				DateTime currentDay = new DateTime(4, i.Month, i.Day);

				if (day != DayOfWeek.Saturday && day != DayOfWeek.Sunday && !holidays.Contains(currentDay))
					workingDayCounter++;

			}
			Console.WriteLine(workingDayCounter);

		}
	}
}
