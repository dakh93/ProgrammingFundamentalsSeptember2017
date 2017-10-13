using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            PrintMostFrequentNum(numbers);

        }

        static void PrintMostFrequentNum(int[] numbers)
        {
            int curCounter = 0;
            int oldCounter = 0;
            int curNum = 0;
            int oldNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        curCounter++;
                        curNum = numbers[i];
                    }

                }
                if (curCounter > oldCounter)
                {
                    oldNum = curNum;
                    oldCounter = curCounter;
                }
                curCounter = 0;
            }
            Console.WriteLine(oldNum);
        }
        
    }
}
