using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int finalPoint = int.Parse(Console.ReadLine());

            for (int i = startPoint; i <= finalPoint; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}
