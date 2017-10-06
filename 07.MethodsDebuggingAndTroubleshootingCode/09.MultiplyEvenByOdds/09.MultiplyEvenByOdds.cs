using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            MultiplySumOfEvenOdd(number);
        }

        static void MultiplySumOfEvenOdd(int number)
        {
            GetOddSum(number);
            GetEvenSum(number);

            int result =Math.Abs(GetEvenSum(number) * GetOddSum(number));
            Console.WriteLine(result);
        }

        static int GetEvenSum(int number)
        {
            int evenSum = 0;
            while (number !=0)
            {
                int digitCheck = number % 10;
                number /= 10;
                if (digitCheck % 2 == 0)
                {
                    evenSum += digitCheck;
                }
            }
            return evenSum;
        }

        static int GetOddSum(int number)
        {

            int oddSum = 0;
            while (number != 0)
            {
                int digitCheck = number % 10;
                number /= 10;
                if (digitCheck % 2 != 0)
                {
                    oddSum += digitCheck;
                }
            }
            return oddSum;
        }
    }
}
