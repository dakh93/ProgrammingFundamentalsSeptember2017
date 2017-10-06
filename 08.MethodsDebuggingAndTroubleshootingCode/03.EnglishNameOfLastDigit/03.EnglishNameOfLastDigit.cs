using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetLastDigitName(Math.Abs(number));
        }

        static void GetLastDigitName(int number)
        {
            int lastDigit = number % 10;

            string[] digits = new string[]
                {"zero", "one", "two", "three", "four",
                    "five", "six", "seven", "eight", "nine"};
            

            Console.WriteLine(digits[lastDigit]);
        }
    }
}
