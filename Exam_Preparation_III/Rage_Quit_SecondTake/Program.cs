using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Rage_Quit_SecondTake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(input, @"(\D+)(\d+)"); // ne cheti uslovieto!   degsko3abi4sfsdfsdfg
			var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var text = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
