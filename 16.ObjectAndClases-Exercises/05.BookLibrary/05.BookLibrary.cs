using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            Library library = new Library();
            List<Book> books = new List<Book>();
            Library book = new Library();

            for (int i = 0; i < n; i++)
            {
                Book curBook = ReadBook();

                 books.Add(curBook);
                
            }
            library.Books = books;
            PrintBooksPriceSum(library);

        }

        static void PrintBooksPriceSum(Library library)
        {
            var orderBooks =
                library.Books.GroupBy(x => x.Author)
                    .Select(b => new
                    {
                        Author = b.Key,
                        Price = b.Sum(v => v.Price)
                    })
                    .OrderByDescending(p => p.Price)
                    .ThenBy(a => a.Author)
                    .ToList();

            foreach (var orderBook in orderBooks)
            {
                Console.WriteLine($"{orderBook.Author} -> {orderBook.Price:f2}");
            }


        }

        private static Book ReadBook()
        {
            Book curBook = new Book();

            string[] input = Console.ReadLine().Split().ToArray();

            curBook.Title = input[0];
            curBook.Author = input[1];
            curBook.Publisher = input[2];
            curBook.ReleaseDate = DateTime.ParseExact(
                input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            curBook.ISBN = input[4];
            curBook.Price = double.Parse(input[5]);

            return curBook;
        }
    }
}
