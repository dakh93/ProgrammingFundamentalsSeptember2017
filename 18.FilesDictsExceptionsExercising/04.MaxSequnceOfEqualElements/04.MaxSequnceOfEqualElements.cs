using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequnceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\input.txt");

            foreach (var line in lines)
            {
                int[] numbers =
                    line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                PrintLongestLeftSequence(numbers);
            }



        }

        private static void PrintLongestLeftSequence(int[] numbers)
        {
            int equalNum = 0;
            int counter = 1;
            int saveCounter = 0;
            int currentEqual = 0;
            int oldCounter = 0;
            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentEqual = numbers[i];
                    counter++;
                    if (counter >= saveCounter)
                    {
                        saveCounter = counter;
                        equalNum = currentEqual;


                    }


                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < saveCounter; i++)
            {
                File.AppendAllText(
                    @"..\..\output.txt", 
                    equalNum.ToString() + " ");
            }
            File.AppendAllText(@"..\..\output.txt", Environment.NewLine);
            string splitLines = "-------------";
            File.AppendAllText(@"..\..\output.txt" ,splitLines + Environment.NewLine );

        }
    }
}
