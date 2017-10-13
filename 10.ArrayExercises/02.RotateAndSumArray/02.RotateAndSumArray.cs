using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSumArray
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
            int rotationCycles = int.Parse(Console.ReadLine());

            PrintSumOfArrays(numbers, rotationCycles);
        }

        private static void PrintSumOfArrays(int[] numbers, int rotationCycles)
        {
         
            int[] arraySum = new int[numbers.Length];
            for (int i = 0; i < rotationCycles; i++)
            {
                
                    int temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j >= 1; j--)
                {


                    numbers[j] = numbers[j - 1];
                    
                    arraySum[j] += numbers[j];
                    
                }
                numbers[0] = temp;
                arraySum[0] += numbers[0];
            }
            Console.WriteLine(String.Join(" ",arraySum));
        }
    }
}
