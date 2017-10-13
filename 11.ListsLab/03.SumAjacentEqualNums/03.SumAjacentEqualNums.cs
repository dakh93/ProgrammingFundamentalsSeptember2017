using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAjacentEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> number =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToList();

            decimal sum = 0;
            for (int i = 1; i < number.Count; i++)
            {
                if (number[i] == number[i -1])
                {
                    sum = number[i] + number[i - 1];
                    number[i] = sum;
                    number.Remove(number[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(String.Join(" ", number));
        }
    }
}
