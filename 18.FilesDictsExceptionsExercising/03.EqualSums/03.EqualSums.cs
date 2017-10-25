using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\input.txt");

            foreach (var line in lines)
            {
                int[] numbers =
                    line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                PrintEqualSumArrayNumPosition(numbers);
            }
        }

        static void PrintEqualSumArrayNumPosition(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                File.AppendAllText(@"..\..\output.txt", "0");
                SplitBetweenLineResults();
                return;
            }
            else if (numbers.Length == 2)
            {
                GetResult(numbers);
                return;


            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = GetLeftSum(numbers, i);
                int rightSum = GetRightSum(numbers, i);
                if (leftSum == rightSum)
                {
                    File.AppendAllText(@"..\..\output.txt", i.ToString() + Environment.NewLine);
                    SplitBetweenLineResults();
                    return;
                }
            }
            File.AppendAllText(@"..\..\output.txt", "no" + Environment.NewLine);
            SplitBetweenLineResults();
        }

        private static void GetResult(int[] numbers)
        {

            if (numbers[1] == 0)
            {
                File.AppendAllText(@"..\..\output.txt", "0" + Environment.NewLine);
                SplitBetweenLineResults();
            }
            else if (numbers[0] == 0)
            {
                File.AppendAllText(@"..\..\output.txt", "0" + Environment.NewLine);
                SplitBetweenLineResults();
            }
            else
            {
                File.AppendAllText(@"..\..\output.txt", "no" + Environment.NewLine);
                SplitBetweenLineResults();
            }
        }

        private static void SplitBetweenLineResults()
        {
            string splitResults = "-----------------";
            File.AppendAllText(@"..\..\output.txt", splitResults + Environment.NewLine);
        }

        static int GetRightSum(int[] numbers, int curPosition)
        {
            int sum = 0;
            for (int i = curPosition + 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static int GetLeftSum(int[] numbers, int curPosition)
        {
            int sum = 0;
            for (int i = curPosition - 1; i >= 0; i--)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
