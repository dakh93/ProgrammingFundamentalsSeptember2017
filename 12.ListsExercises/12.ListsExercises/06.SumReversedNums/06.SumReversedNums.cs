using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            PrintResult(numbers);
            
           
        }

        private static void PrintResult(List<int> numbers)
        {
            int result = 0;

           result = ReverseNumAndSum(numbers, result);
            Console.WriteLine(result);
        }

        static int ReverseNumAndSum(List<int> numbers, int result)
        {
            char[] currNum;
            for (int i = 0; i < numbers.Count; i++)
            {
                currNum = numbers[i].ToString().ToCharArray();
                Array.Reverse(currNum);
                string reversedString = string.Empty;
                foreach (char element in currNum)
                {
                    reversedString += element;
                }
                result += int.Parse(reversedString);
            }
            return result;
        }
    }
}
