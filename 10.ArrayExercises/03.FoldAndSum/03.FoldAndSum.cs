using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
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

            GetFoldNumberArraysSum(numbers);
        }

        private static void GetFoldNumberArraysSum(int[] numbers)
        {
            
            int[] upperArray = GetUpperArray(numbers);
            int[] lowerArray = GetLowerArray(numbers);
            for (int i = 0; i < upperArray.Length; i++)
            {
                int sumOfPositions = upperArray[i] + lowerArray[i];
                Console.Write($"{sumOfPositions} ");
            }
            Console.WriteLine();
           
                
            
        }

        private static int[] GetLowerArray(int[] numbers)
        {
            int[] lowerArray = new int[numbers.Length / 2];

            int start = numbers.Length / 4;
            int end = numbers.Length - (numbers.Length / 4);
            for (int i = 0; i < numbers.Length / 2 ; i++)
            {
                lowerArray[i] = numbers[start + i];
            }
            return lowerArray;

        }

        static int[] GetUpperArray(int[] numbers)
        {
            int[] upperArray = new int[numbers.Length / 2];
            int start = (numbers.Length / 4) - 1;
            int currentPosition = 0;
            for (int i = 0; i < numbers.Length /4 ; i++)
            {
                upperArray[i] = numbers[start - i];
                currentPosition = i;
            }
            int end = numbers.Length - (numbers.Length / 4);
            for (int i = numbers.Length - 1; i >= end; i--)
            {
                currentPosition++;
                upperArray[currentPosition] = numbers[i];
            }
            return upperArray;
        }
    }
}
