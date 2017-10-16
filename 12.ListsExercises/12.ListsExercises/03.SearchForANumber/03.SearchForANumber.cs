using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
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

            int[] operations =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int numbersToTake = operations[0];
            int numToDelete = operations[1];
            int searchNum = operations[2];

            List<int> takenNums = new List<int>();

            for (int i = 0; i < numbersToTake; i++)
            {
                takenNums.Add(numbers[i]);
            }
            int counter = 0;
            for (int i = 0; i < numToDelete; i++)
            {
                
                takenNums.Remove(takenNums[counter]);
                
            }

            if (takenNums.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
