using System;


namespace Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int flaps = int.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            if (flaps<=0||endurance<=0||endurance>flaps)
            {
                return;
            }

            long timeOfFlight = (flaps / 100) +  5*(flaps / endurance );
            double totalDistance = distancePer1000Flaps * flaps/1000.0;

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{timeOfFlight} s.");

        }
    }
}
