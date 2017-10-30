using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringReversing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputChar = input.ToCharArray();
            Array.Reverse(inputChar);

            Console.WriteLine(inputChar);
        }
    }
}
