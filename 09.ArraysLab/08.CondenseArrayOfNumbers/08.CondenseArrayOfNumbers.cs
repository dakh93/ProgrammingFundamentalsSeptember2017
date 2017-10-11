using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayOfNumbers
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
                Console.WriteLine($"{numbers[0]}");
                return;
                
            }

           int[] finalNumber =  CondensedArray(numbers);
            Console.WriteLine(finalNumber[0]);
        }

        private static int[] CondensedArray(int[] numbers)
        {
            int[] tempArray = new int[numbers.Length - 1];
            while (tempArray.Length != 1)
            {
                tempArray = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    tempArray[i] = numbers[i] + numbers[i + 1];
                }
                numbers = tempArray;

            }
            return numbers;
        }
    }
}
