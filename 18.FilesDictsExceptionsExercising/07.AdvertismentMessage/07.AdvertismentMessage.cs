using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


            int numLines = int.Parse(File.ReadAllText(@"..\..\input.txt"));
            Random text = new Random();


            for (int i = 0; i < numLines; i++)
            {
                int phrase = text.Next(0, phrases.Length);
                int evnt = text.Next(0, events.Length);
                int author = text.Next(0, authors.Length);
                int city = text.Next(0, cities.Length);

                File.AppendAllText(@"..\..\output.txt",
                phrases[phrase] + " " + events[evnt] + " " + 
                authors[author] + " - " + cities[city] + Environment.NewLine);
            }
            string separatorOfDiffInputs = "-------------------";
            File.AppendAllText(@"..\..\output.txt",
                separatorOfDiffInputs + Environment.NewLine);


        }
    }
}
