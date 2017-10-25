using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent =
                File.ReadAllLines(@"..\..\input.txt");
            var lib = ReadAllBooks(fileContent);
            var books = lib.Books;

            var dict = new Dictionary<string, DateTime>();
            string inn = fileContent[fileContent.Length - 1];
            DateTime date = DateTime.ParseExact(inn, "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in books)
            {
                var tit = item.title;
                var relD = item.relDate;
                if (!dict.ContainsKey(tit)) dict.Add(tit, relD);
                else dict[tit] = relD;
            }

            foreach (var item in dict.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                var D = item.Value.Date;
                if (item.Value > date)
                {
                    File.AppendAllText(@"..\..\output.txt",
                        item.Key + " -> " + string.Format("{0:d.MM.yyyy}", D)
                        + Environment.NewLine);

                    
                }
            }
        }
        static Book ReadBook(string[] fileContent, int counter)
        {
            var book = new Book();
            string[] elements = fileContent[counter].Split(' ');
            book.title = elements[0];
            book.relDate = DateTime.ParseExact(elements[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            return book;
        }
        static Library ReadAllBooks(string[] fileContent)
        {
            var libraray = new Library();
            libraray.Books = new List<Book>();
            
            int n = int.Parse(fileContent[0]);
            for (int i = 0; i < n; i++)
            {
                int counter = i + 1;
                var book = ReadBook(fileContent,counter);
                libraray.Books.Add(book);
            }
            return libraray;
        }
    }
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime relDate { get; set; }
        public string ISBN { get; set; }
        public decimal price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
