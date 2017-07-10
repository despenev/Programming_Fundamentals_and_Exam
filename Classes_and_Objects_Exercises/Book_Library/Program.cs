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
			//var authorsales = library.Books.Select(a => a.Author)
			//                         .Distinct().
			//                         Select(author => new AuthorInfo() 
			//{
			//	Author = author,
			//	TotalSales = library.
			//	                    Books.
			//	                    Where(book => book.Author == author).
			//	                    Sum(book => book.Pricee)
			//}
			//                               )
			//                         .OrderByDescending(AuthorInfo => AuthorInfo.TotalSales)
			//                         .ThenBy(AuthorInfo => AuthorInfo.Author);

			//foreach (var author in authorsales)
			//{
			//	Console.WriteLine($"{author.Author} -> {author.TotalSales:f2}");
			//}



			foreach (var book in library.Books.GroupBy(a=>a.Author).OrderByDescending(a=>a.Sum(y=>y.Pricee)).ThenBy(a=>a.Key))
			{
				Console.WriteLine($"{book.Key} -> {book.Sum(x=>x.Pricee)}");
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
