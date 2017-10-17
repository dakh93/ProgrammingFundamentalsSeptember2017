using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberNum = int.Parse(Console.ReadLine());


            int[] number = new int[numberNum];

            for (int i = 0; i < numberNum; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Sum = {number.Sum()}");
            Console.WriteLine($"Min = {number.Min()}");
            Console.WriteLine($"Max = {number.Max()}");
            Console.WriteLine($"Average = {number.Average()}");


        }
    }
}
