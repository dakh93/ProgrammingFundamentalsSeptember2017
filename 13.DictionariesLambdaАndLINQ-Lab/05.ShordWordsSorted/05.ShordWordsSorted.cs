using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShordWordsSorted
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> text =
                Console.ReadLine()
                .ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']',
                        '"', '\'', '\\', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries)
               
                .ToList();

            List<string> result = text.Where(word => word.Length < 5).OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
