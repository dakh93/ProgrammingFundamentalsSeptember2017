using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            foreach (var letter in input)
            {
                string result = "\\u" + ((int) letter).ToString("x4");
                Console.Write(result);

            }
            Console.WriteLine();
        }
    }
}
