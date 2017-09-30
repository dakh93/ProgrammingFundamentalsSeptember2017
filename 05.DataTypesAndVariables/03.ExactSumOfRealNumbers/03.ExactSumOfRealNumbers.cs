using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToAdd = int.Parse(Console.ReadLine());

            decimal sumOfNumbers = 0;
            for (int i = 0; i < numbersToAdd; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sumOfNumbers += number;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
