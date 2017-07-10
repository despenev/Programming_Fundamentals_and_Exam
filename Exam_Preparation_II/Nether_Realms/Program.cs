using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var demonsNames = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var demon in demonsNames.OrderBy(a=>a))
            {
                var name = demon;
                double health = 0;
                double damage = 0;
               
                    Regex regex = new Regex(@"(\+|-){0,1}[0-9]+(\.[0-9]+)*");

                var matches = regex.Matches(name);
                foreach (Match num in matches)
                {
                    var damInc = double.Parse(num.ToString());
                    num.ToString();
                    damage+=damInc;
                }

                Regex division = new Regex(@"\/");
                var divisionMatches = division.Matches(name);
                var totalDivision = divisionMatches.Count;
            
                while (totalDivision>0)
                {
                    if(damage!=0)
                    damage =damage/ 2;
                    totalDivision--;
                }
                var multiplicationMatches = Regex.Matches(name,@"\*");
                var totalMultiplication = multiplicationMatches.Count;
                while (totalMultiplication > 0)
                {
                    if (damage != 0)
                        damage = damage * 2;
                    totalMultiplication--;
                }

                Regex asciLetters = new Regex(@"[^0-9+\-*\/\.]");
                health = asciLetters.Matches(name)
                                                .Cast<Match>()
                                                .Select(a => (int)char.Parse(a.Value))
                                                .Sum();
                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");






            }
        }
    }
}
