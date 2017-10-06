using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberSign(number);
        }

        static void PrintNumberSign(int number)
        {
            string sign = string.Empty;     
            if (number < 0)
            {
                sign = "negative";
            }
            else if (number > 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "zero";
            }
            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
