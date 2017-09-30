using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToStop = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int currentNumber = 0;
            bool checker = false;
            for (int ch = 1; ch <= numberToStop; ch++)
            {
                currentNumber = ch;
                while (currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber /= 10;
                }
                checker = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{ch} -> {checker}");
                sumOfDigits = 0;
                
            }

        }
    }
}
// CODE FOR REFACTORING
/*
 int kolkko = int.Parse(Console.ReadLine());
int obshto = 0; int takova = 0; bool toe = false;
for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }
    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
    Console.WriteLine($"{takova} -> {toe}");
    obshto = 0;
    ch = takova;
}

*/
