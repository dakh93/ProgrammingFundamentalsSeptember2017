using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10.ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstText =
                Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            string[] secondText =
                Console.ReadLine()
                    .Split(' ')
                    .ToArray();

            FindLargestCommonEnd(firstText, secondText);
        }

        private static void FindLargestCommonEnd(string[] firstText, string[] secondText)
        {
            int maxLenght = Math.Min(firstText.Length, secondText.Length);
            int firstCounter = 0;
            for (int i = 0; i < maxLenght; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    firstCounter++;
                }
            }
            int reverseCounter = 0;
            Array.Reverse(firstText);
            Array.Reverse(secondText);
            for (int i = 0; i < maxLenght; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    reverseCounter++;
                }
            }

            int largestCommonWords = Math.Max(firstCounter, reverseCounter);
            Console.WriteLine(largestCommonWords);
        }
    }
}
