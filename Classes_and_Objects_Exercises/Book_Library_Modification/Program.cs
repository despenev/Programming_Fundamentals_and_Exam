using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			var library = new Library() { Name = "huyo", Books = new List<Book>() };
			for (int i = 0; i < num; i++)
			{
				var tokens = Console.ReadLine().Split().ToList();
				var title = tokens[0];
				var author = tokens[1];
				var publisher = tokens[2];
				var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
				var ISBN = tokens[4];
				var price = decimal.Parse(tokens[5]);


				var book = new Book
				{
					Title = title,
					Author = author,
					Publisher = publisher,
					ReleaseDate = releaseDate,
					ISBN = ISBN,
					Pricee = price
				};
				library.Books.Add(book);
			}
			var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

			var endlibrary = library.Books.Where(a => a.ReleaseDate >= date).OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title);
			foreach (var book in endlibrary)
			{
				Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
			}

		}
		class AuthorInfo
		{
			public string Author { get; set; }
			public decimal TotalSales { get; set; }
		}
		class Library
		{
			public string Name
			{
				get;
				set;
			}
			public List<Book> Books
			{
				get;
				set;
			}
		}
		class Book
		{
			public string Title
			{
				get;
				set;
			}
			public string Author
			{
				get;
				set;
			}
			public string Publisher
			{
				get;
				set;
			}
			public DateTime ReleaseDate
			{
				get;
				set;
			}
			public string ISBN
			{
				get;
				set;
			}
			public decimal Pricee
			{
				get;
				set;
			}
		}
	}
}
