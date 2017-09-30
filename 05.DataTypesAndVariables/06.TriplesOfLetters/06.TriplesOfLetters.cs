using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < n + 'a'; i++)
            {
                for (char k = 'a'; k < n + 'a'; k++)
                {
                    for (char j = 'a'; j < n + 'a'; j++)
                    {
                        Console.WriteLine($"{i}{k}{j}");
                    }
                }
            }
        }
    }
}
