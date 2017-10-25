using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BookLibrary
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
            string[] fileContent =
                File.ReadAllLines(@"..\..\input.txt");
            int n = int.Parse(fileContent[0]);

            Library library = new Library();
            List<Book> books = new List<Book>();
            Library book = new Library();

            for (int i = 0; i < n; i++)
            {
                int counter = i + 1;
                Book curBook = ReadBook(fileContent, counter);

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
                File.AppendAllText
                    (@"..\..\output.txt",
                    orderBook.Author + " -> " + string.Format("{0:f2}", orderBook.Price) +
                    Environment.NewLine);
               // Console.WriteLine($"{orderBook.Author} -> {orderBook.Price:f2}");
            }


        }

        private static Book ReadBook(string[] fileContent, int counter)
        {
            
            Book curBook = new Book();

            string[] input = fileContent[counter].Split(' ').ToArray();

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
