using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintFibonacciNum(number);
        }

        static void PrintFibonacciNum(int number)
        {
            int a = 1;
            int b = 1;
            int sum = 0;
            if (number == 1 || number == 0)
            {
                Console.WriteLine(a);
                return;
            }

            for (int i = 2; i <= number; i++)
            {
                sum = a + b;
                int temp = sum;
                a = b;
                b = temp;
            }
            Console.WriteLine(sum);
        }



    }
}
