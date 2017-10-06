using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();


            PrintReversedNum(number);
        }

        static void PrintReversedNum(string number)
        {
            char[] reversedNum = number.ToCharArray();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(reversedNum[i]);
            }
            Console.WriteLine();
        }
    }
}
