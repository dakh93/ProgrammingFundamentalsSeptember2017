using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintPrimeNumsToN(number);
        }

        private static void PrintPrimeNumsToN( int number)
        {
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine($"{i}");
                    
                }
            }
        }
    }
}
