using System;
using System.Collections.Generic;
using System.Linq;

namespace Charity_Marathon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avgLaps = int.Parse(Console.ReadLine());
            double lapLength = double.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            double totalKm = 0;

            while (days > 0 && runners > 0)
            {
                if (runners>capacity)
                {
                    runners -= capacity;
                    totalKm += capacity * lapLength * avgLaps / 1000;
                }
                else if(runners<=capacity)
                {
                    totalKm += runners * avgLaps * lapLength / 1000;
                    runners = 0;
                }

                days--;
            }

            double moneyRaised = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");



        }
    }
}
