using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            PrintLongestLeftIncreasingSequence(numbers);

        }
         static void PrintLongestLeftIncreasingSequence(int[] numbers)
        {
            int counter = 0;
            int maxCounter = 0;

            int curStart = 0 ;
            int maxStart = 0;
            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i - 1] < numbers[i])
                {
                    counter++;
                    curStart = i - counter;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxStart = curStart;
                    }

                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = maxStart; i <= maxStart + maxCounter; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

        }
    }
}
