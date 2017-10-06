using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopAndBottomPart(n);
            PrintMainPart(n);
            PrintTopAndBottomPart(n);

        }

        static void PrintMainPart(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");
                for (int i = 0; i < ((n * 2) - 2) / 2; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
                
            }
        }

        static void PrintTopAndBottomPart(int n)
        {
            Console.WriteLine($"{new string('-', n * 2)}");
        }
    }
}
