using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Phonebook = new Dictionary<string, string>();
            while (true)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "A":
                        {
                            var contact = Console.ReadLine().Split().ToList();
                            if (!Phonebook.ContainsKey(contact[0]))
                            {
                                Phonebook.Add(contact[0], contact[1]);
                            }
                            else Phonebook[contact[0]] = contact[1];
                            break;
                        }
                    case "S":
                        {
                            var contact = Console.ReadLine();
                            if (Phonebook.ContainsKey(contact))
                                Console.WriteLine($"{contact} -> {Phonebook[contact]}");
                            else Console.WriteLine($"Contact {contact} does not exist");
                            break;
                        }
                        case "END":
                        { return; }
                }
            }
        }
    }
}
