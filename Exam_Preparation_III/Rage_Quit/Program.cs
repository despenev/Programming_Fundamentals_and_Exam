using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace Rage_Quit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var regexUniqueSymbols = new Regex(@"[^0-9]");
            var UniqueSymbolsMatches= regexUniqueSymbols.Matches(input).Cast<Match>().Select(a=>a.Value).Distinct().ToList();
            var UniqueSymbolsCount = UniqueSymbolsMatches.Count;
            var stringBuilder = new StringBuilder();

            var regexRageText = new Regex(@"(?<rageTxt>[^0-9]+)");
            var regexMultiply = new Regex(@"(?:[0-9])+");
            var rageTextList = regexRageText.Matches(input).
                                            Cast<Match>().
                                            Select(a => a.Value).
                                            ToList();
            
            var txtMultiplyList = regexMultiply.Matches(input).
                                           Cast<Match>().
                                               Select(a => int.Parse(a.Value)).
                                           ToList();


            var printList = new List<string>();


            for (int i = 0; i < txtMultiplyList.Count; i++)
            {
                var count = txtMultiplyList[i];
                while (count>0)
                {
                    stringBuilder.Append(rageTextList[i]);
                    count--;
                }
            }

			Console.WriteLine($"Unique symbols used: {UniqueSymbolsCount}");
            Console.WriteLine(stringBuilder);


        }
    }
}
