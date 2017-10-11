using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractElementsOfArray
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

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
                return;
                
            }

            int[] middleNums = GetMiddleNumbers(numbers);
            Console.WriteLine($"{{ {String.Join(", ",middleNums)} }}");
        }

        private static int[] GetMiddleNumbers(int[] numbers)
        {
            int[] middleNums;
            if (numbers.Length % 2 == 0)
            {
                middleNums = new int[2];
                int startPoint = (numbers.Length / 2) - 1;
                int endPoint = startPoint + 1;
                int counter = 0;
                for (int i = startPoint; i <= endPoint; i++)
                {
                    middleNums[counter] = numbers[i];
                    counter++;
                }
            }
            else
            {
                middleNums = new int[3];
                int startPoint = (numbers.Length / 2) - 1;
                int endPoint = startPoint + 2;
                int counter = 0;
                for (int i = startPoint; i <= endPoint; i++)
                {
                    middleNums[counter] = numbers[i];
                    counter++;
                }
            }
            return middleNums;
        }
    }
}
