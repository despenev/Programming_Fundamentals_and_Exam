using System;

namespace Advertisement_Message
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());

			string[] phrase =  { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
			string[] events =  { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
			string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
			string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

			var random = new Random();

			for (int i = 0; i < input; i++)
			{
				var PhraseIndex = random.Next(0, phrase.Length);
				var EventIndex = random.Next(0, events.Length);
				var AuthorIndex = random.Next(0, authors.Length);
				var CityIndex = random.Next(0, cities.Length);

				Console.WriteLine($"{authors[AuthorIndex]} {events[EventIndex]} {authors[AuthorIndex]} – {cities[CityIndex]}.");

			}




		}
	}
}
