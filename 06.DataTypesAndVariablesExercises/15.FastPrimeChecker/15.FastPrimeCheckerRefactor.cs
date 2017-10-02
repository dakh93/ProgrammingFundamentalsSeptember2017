using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
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
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}

/*
 * int ___Do___ = int.Parse(Console.ReadLine());
for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
{    bool TowaLIE = true;
         for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
    {
        if  (DAVIDIM % delio == 0)
        {
            TowaLIE = false;
            break;
        }
    }
    Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
}

 */
 
