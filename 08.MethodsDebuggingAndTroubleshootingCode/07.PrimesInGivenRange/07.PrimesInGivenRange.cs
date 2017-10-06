using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimeNumbersInRange(startNum, stopNum);
            Console.WriteLine(String.Join(", ",primes));
        }

        static List<int> FindPrimeNumbersInRange(int startNum, int stopNum)
        {
            List<int> primes = new List<int>();
            for (int currentNum = startNum; currentNum <= stopNum; currentNum++)
            {
                if (isPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
                
            }
            return primes;

        }

        static bool isPrime(long number)
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
