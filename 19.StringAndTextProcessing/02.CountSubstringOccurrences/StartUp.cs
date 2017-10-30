using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text =
                Console.ReadLine().ToLower();
            string occur = Console.ReadLine().ToLower();

            int startIndex = text.IndexOf(occur);
            int counter = 0;
            while (startIndex != -1)
            {
                counter++;
                startIndex = text.IndexOf(occur,startIndex + 1);

            }
            Console.WriteLine(counter);
        }
    }
}
