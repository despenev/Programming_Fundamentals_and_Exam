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
				var contact = Console.ReadLine().Split().ToList();

				switch (contact[0])
				{
					case "A":
						{
							if (!Phonebook.ContainsKey(contact[1]))
							{
								Phonebook.Add(contact[1], contact[2]);
							}
							else Phonebook[contact[1]] = contact[2];
							break;
						}
					case "S":
						{
							
							if (Phonebook.ContainsKey(contact[1]))
								Console.WriteLine($"{contact[1]} -> {Phonebook[contact[1]]}");
							else Console.WriteLine($"Contact {contact[1]} does not exist");
							break;
						}
					case "END":
						{ return; }
				}
			}
		}
	}
}
