using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            int equalNum = 0;
            int counter = 1;
            int saveCounter = 0;
            int currentEqual = 0;
            
            for (int i = numbers.Count - 1; i >= 1; i--)
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

            if (saveCounter == 0)
            {
                Console.WriteLine($"{numbers[0]}");
                return;
            }
            for (int i = 0; i < saveCounter; i++)
            {
                Console.Write($"{equalNum} ");
            }
            Console.WriteLine();
        }
    }
}
