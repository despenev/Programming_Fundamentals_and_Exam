using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Count_Woring_Days_Vladi
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var holidays = new[]
			{
				// dati kato string
			}.Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture));


			var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture);
			var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
			var workingdayscount = 0;
			for (DateTime i = startDate; i < endDate; i= i.AddDays(1))
			{

				var isSatorSunday = i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Saturday;

				var isHoliday = holidays.Any(d => d.Day == i.Day && d.Month == i.Month);
				var isWorkingDay = !(isHoliday && isSatorSunday);
				if (isWorkingDay)
				{ workingdayscount++;}
			}
			Console.WriteLine(workingdayscount);
		}
	}
}
