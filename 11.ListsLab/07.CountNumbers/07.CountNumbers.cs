using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            numbers.Sort();
            List<int> noDuplicateNums = new List<int>();
            
            int counter = 1;
            bool lastNumPrint = false;
            for (int i = 0; i < numbers.Count- 1 ; i++)
            {
                if (i == numbers.Count - 1)
                {
                    lastNumPrint = true;
                }
                
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {counter} ");
                    counter = 1;
                }

            }
            if (!lastNumPrint)
            {
                Console.WriteLine($"{numbers[numbers.Count - 1]} -> {counter}");
            }
        }
    }
}
