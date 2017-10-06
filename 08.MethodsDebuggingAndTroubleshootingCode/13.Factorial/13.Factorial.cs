using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = number; i >= 2; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
