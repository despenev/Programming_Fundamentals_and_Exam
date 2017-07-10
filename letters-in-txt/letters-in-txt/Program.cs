using System;
using System.Linq;

namespace lettersintxt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var txt = Console.ReadLine().ToList();
            var letters = new int[26];

            foreach (var letter in txt)
            {
                if(char.IsLetter(letter))
                {
                    letters[letter - 'a']++; 
                }
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i]>0)
                {
                    Console.WriteLine($"{(char)('a'+i)} - {letters[i]}");
                }
                    
            }

        }
    }
}
