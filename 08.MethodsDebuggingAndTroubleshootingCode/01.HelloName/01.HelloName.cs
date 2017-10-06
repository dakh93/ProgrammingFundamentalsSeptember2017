using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintHelloName(name);


        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
