using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexMon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pokeWordRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");
            var matchedPokeWord = pokeWordRegex.Matches(input);
            var noDashNoLetterRegex = new Regex(@"[^a-zA-Z-]+");
            var matchedNoNo = noDashNoLetterRegex.Matches(input);
            var count = 1;
            var indexOfLastMatch = 0;

            while (true)
            {
                if (count % 2 == 1)
                {
                    var match = noDashNoLetterRegex.Match(input, indexOfLastMatch);
                    if (!match.Success)
                    {
                        return;
                    }
                    indexOfLastMatch = match.Index;
                    Console.WriteLine(match.Value);
                }
                else
                {
                    var match = pokeWordRegex.Match(input, indexOfLastMatch);
                    if (!match.Success)
                    {
                        return;
                    }
                    indexOfLastMatch = match.Index;
                    Console.WriteLine(match.Value);

                }
                count++;

            }
        }
    }
}
