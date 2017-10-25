using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(0, input.Length);
                string rem = input[index];
                int newIndex = rnd.Next(0, input.Length);
                input[index] = input[newIndex];
                input[newIndex] = rem;
                

            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
