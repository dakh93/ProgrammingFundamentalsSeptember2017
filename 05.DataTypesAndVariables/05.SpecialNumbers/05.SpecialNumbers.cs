using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalNum = int.Parse(Console.ReadLine());
            bool isTrue = false;

            for (int i = 1; i <= finalNum; i++)
            {
                int sum = 0;
                int number = i;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }

                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
