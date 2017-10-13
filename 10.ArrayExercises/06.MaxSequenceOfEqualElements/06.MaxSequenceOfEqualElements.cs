using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
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

            PrintLongestLeftSequence(numbers);

            
        }

        private static void PrintLongestLeftSequence(int[] numbers)
        {
            int equalNum = 0;
            int counter = 1;
            int saveCounter = 0;
            int currentEqual = 0;
            int oldCounter = 0;
            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                if (numbers[i] == numbers[i -1])
                {
                    currentEqual = numbers[i];
                    counter++;
                    if (counter >= saveCounter)
                    {
                        saveCounter = counter;
                        equalNum = currentEqual;


                    }
                    
                        
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < saveCounter; i++)
            {
                Console.Write($"{equalNum} ");
            }
            Console.WriteLine();
           
        }
    }
}
