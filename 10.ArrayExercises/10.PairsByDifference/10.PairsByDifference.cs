using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            int difference = int.Parse(Console.ReadLine());

            PrintPairNumber(number, difference);
        }

        static void PrintPairNumber(int[] number, int difference)
        {
            int counter = 0;
            int countPairs = 0;
            int start = number.Length - (number.Length - counter);
            for (int i = start + counter; i < number.Length; i++)
            {
                for (int j = start + counter; j < number.Length; j++)
                {
                    if (Math.Abs(number[i] - number[j]) == difference)
                    {
                        countPairs++;
                    }
                }
                counter++;
            }
            Console.WriteLine(countPairs);
        }
    }
}
