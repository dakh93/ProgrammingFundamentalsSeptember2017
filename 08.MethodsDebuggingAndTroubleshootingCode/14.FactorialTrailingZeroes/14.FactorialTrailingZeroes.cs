using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = FactorialOfNumber(number);
            HoWManyZeroOnTail(factorial);
        }

        static void HoWManyZeroOnTail(BigInteger factorial)
        {
            int zeroCounter = 0;
            while (factorial % 10 == 0)
            {
                zeroCounter++;
                factorial /= 10;
            }
            Console.WriteLine(zeroCounter);
            
        }

        static BigInteger FactorialOfNumber(int number)
        {
            BigInteger factorial = 1;

            for (int i = number; i >= 2; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
