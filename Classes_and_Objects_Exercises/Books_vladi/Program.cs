using System;
using System.Collections.Generic;
using System.Linq;
namespace Books_vladi
{
	class MainClass
	{
		class Book
		{
			public string Title { get; set;}

			public string Author { get; set; }

			public string Publisher { get; set; }

			public DateTime ReleaseDate { get; set; }

			public string Isbn { get; set; }

			public decimal Price { get; set; }

		}

		class Library 
		{
			public List<Book> Books
			{
				get;
				set;
			}
		}
		class AuthorInfo
		{
			public string Author
			{
				get;
				set;
			}
			public decimal Sales
			{
				get;
				set;
			}
		}
		public static void Main(string[] args)
		{
			var library = new Library()
			{

			};
			var booksCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < booksCount; i++)
			{
				var tokens = Console.ReadLine().Split();
				var author = tokens[1];
				var title = tokens[0];
				var publisher = tokens[2];
				var releaseDate = DateTime.ParseExact(tokens[3]);
				var isbn = tokens[4];
				var pruce = decimal.Parse(tokens[5]);


				//var book = new Book(
				//library.add(book
			}

			var authorsalees = library.Books.Select(a => a.Author)
									 .Distinct()
									 .Select(author => new AuthorInfo
									 {
				Author= author,
				Sales = library.Books.Where(book=> book.Author==author).Sum(b=> b.Price)
			})
			                          .OrderByDescending(AuthorInfo=> AuthorInfo.;
		}
	}
}
