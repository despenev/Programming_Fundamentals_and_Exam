using System;
using System.Linq;
using System.Collections.Generic;

namespace FixEmails
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var hands = new Dictionary<string, List<string>>();
			var person = "";


			while (true)
			{
				var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				person = input[0];

				if (person == "JOKER") break;

				List<string> cards = new List<string>();
				for (int i = 1; i < input.Count; i++)
				{
					cards.Add(input[i]);
				}

				if (!hands.ContainsKey(person))
				{
					hands[person] = cards;
				}
				else
				{
					hands[person].AddRange(cards);
				}
			}
		}
		public static void Result(Dictionary<string, List<string>> hands)
		{
			foreach (var hand in hands)
			{
				var person = hand.Key;
				var cards = hand.Value.Distinct().ToList();
			}
		}

}
}
