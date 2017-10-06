using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                PrintTriangleOfNumbers(1,i);
            }
            for (int i = number; i >= 1; i--)
            {
                PrintTriangleOfNumbers(1, i);
            }

        }

        static void PrintTriangleOfNumbers(int start,int end)
        {

                for (int i = start; i <= end; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            
        }
    }
}
