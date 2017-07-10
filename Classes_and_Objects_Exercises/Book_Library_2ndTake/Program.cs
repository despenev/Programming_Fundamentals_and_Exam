using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace Book_Library_2ndTake
{
	class MainClass
	{
		class Book
		{
			public string Title { get; set; }
			public string Author { get; set; }
			public string Publisher { get; set; }
			public DateTime ReleaseDate { get; set; }
			public string Isbn { get; set; }
			public decimal Price { get; set; }
		}

		public static void Main(string[] args)
		{
			var library = new List<Book>();
			var num = int.Parse(Console.ReadLine());

			for (int i = 0; i < num; i++)
			{
				var tokens = Console.ReadLine().Split().ToList();
				var title = tokens[0];
				var author = tokens[1];
				var publisher = tokens[2];
				var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);
				var isbn = tokens[4];
				var price = decimal.Parse(tokens[5]);

				Book book = new Book()
				{
					Title = title,
					Author = author,
					Publisher = publisher,
					ReleaseDate = releaseDate,
					Isbn = isbn,
					Price = price
				};
				library.Add(book);
			}

			foreach (var book in library.GroupBy(x=>x.Author).OrderByDescending(x=>x.Sum(y=>y.Price)).ThenBy(x=>x.Key) )
			{
				Console.WriteLine($"{book.Key} -> {book.Sum(x=>x.Price):f2}");
			}
		}
	}
}
