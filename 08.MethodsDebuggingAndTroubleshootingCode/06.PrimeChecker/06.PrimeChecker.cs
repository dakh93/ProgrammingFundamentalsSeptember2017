using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            PrimeCheck(number);
            Console.WriteLine(PrimeCheck(number));
        }

        static bool PrimeCheck(long number)
        {
            

            if (number == 0 || number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            double num = Math.Sqrt(number);
            for (int i = 2; i <= num; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
