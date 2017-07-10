using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


namespace Softuni_Coffee_Orders
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;
            for (int i = 0; i < N; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var dateOfOrder = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var numberOfCapsules = int.Parse(Console.ReadLine());

               
                var daysOfMonth = System.DateTime.DaysInMonth(dateOfOrder.Year, dateOfOrder.Month);

                var priceOfCoffee = pricePerCapsule * numberOfCapsules * daysOfMonth;
                totalPrice += priceOfCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
