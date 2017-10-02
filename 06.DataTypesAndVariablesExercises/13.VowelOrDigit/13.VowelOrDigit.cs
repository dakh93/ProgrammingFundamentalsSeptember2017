using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            string symbol = Console.ReadLine();

            int digit;
            bool isDigit = int.TryParse(symbol, out digit);
            if (isDigit == true)
            {
                Console.WriteLine("digit");
                
            }
            else if (symbol == "a" || symbol == "e" || symbol == "i" ||
                symbol == "o" || symbol == "u" || symbol == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
