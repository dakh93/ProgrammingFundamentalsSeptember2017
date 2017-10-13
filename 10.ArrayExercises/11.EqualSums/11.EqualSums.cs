using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
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

            PrintEqualSumArrayNumPosition(numbers);
        }

        static void PrintEqualSumArrayNumPosition(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            else if (numbers.Length == 2)
            {
                GetResult(numbers);
                return;
                

            }
            for (int i = 0; i < numbers.Length; i++)
            {
               int leftSum = GetLeftSum(numbers, i);
               int rightSum = GetRightSum(numbers, i);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }

        private static void GetResult(int[] numbers)
        {
            
            if (numbers[1] == 0)
            {
                Console.WriteLine("0");
                
            }
            else if (numbers[0] == 0)
            {
                Console.WriteLine("0");
                
            }
            else
            {
                Console.WriteLine("no");
                

            }
        }

        static int GetRightSum(int[] numbers, int curPosition)
        {
            int sum = 0;
            for (int i = curPosition + 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static int GetLeftSum(int[] numbers, int curPosition)
        {
            int sum = 0;
            for (int i = curPosition - 1; i >= 0; i--)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
