using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var command = Console.ReadLine();
			var dumi = new List<string>();
			var Phonebook = new Dictionary<string, string>();

			while (command != "END") 
				
			{
				var input = command.Split(' ');
				foreach (var item in input)
				{
					dumi.Add(item);
				}
				command = Console.ReadLine();

			}

			for (int i = 0; i<dumi.Count; i++)
			{
				
				if (dumi[i] == "A") 
				{
					Phonebook[dumi[i + 1]] = dumi[i+2];

				}
				if (dumi[i] == "S") 
				{
					

					if (Phonebook.ContainsKey(dumi[i + 1])) 
					{
						Console.WriteLine($"{dumi[i+1]} -> {Phonebook[dumi[i+1]]}");
					}
					else Console.WriteLine($"Contact {dumi[i+1]} does not exist.");
				}
				if (dumi[i] == "ListAll") 
				{
					var ordered = Phonebook.OrderBy(x=>x.Key);
					foreach (KeyValuePair<string,string>pair in ordered)
					{
						Console.WriteLine($"{pair.Key} -> {pair.Value}");
					}
				}
			}
		}
	}
}
