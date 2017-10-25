using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers =File.ReadAllLines(@"..\..\input.txt").ToArray();

            
            PrintMostFrequentNum(numbers);

        }

        static void PrintMostFrequentNum(string[] numbers)
        {
            foreach (var number in numbers)
            {
                int[] currNum = number.Split(' ').Select(int.Parse).ToArray();
                int curCounter = 0;
                int oldCounter = 0;
                int curNum = 0;
                int oldNum = 0;
            
                for (int i = 0; i < currNum.Length; i++)
                {
                    for (int j = 0; j < currNum.Length; j++)
                    {
                        if (currNum[i] == currNum[j])
                        {
                            curCounter++;
                            curNum = currNum[i];
                        }

                    }
                    if (curCounter > oldCounter)
                    {
                        oldNum = curNum;
                        oldCounter = curCounter;
                    }
                    curCounter = 0;
                }
                File.AppendAllText(@"..\..\output.txt", oldNum.ToString() +
                    Environment.NewLine);
            }
        }

    }
}
