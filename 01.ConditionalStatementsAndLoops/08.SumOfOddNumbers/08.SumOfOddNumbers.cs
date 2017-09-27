using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOdds = int.Parse(Console.ReadLine());

            int counter = 0;
            int sumOfOdds = 0;
            for (int i = 1; i < int.MaxValue; i+=2 )
            {
                Console.WriteLine(i);
                sumOfOdds += i;
                counter++;
                if (numberOfOdds == counter)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sumOfOdds}");

        }
    }
}
