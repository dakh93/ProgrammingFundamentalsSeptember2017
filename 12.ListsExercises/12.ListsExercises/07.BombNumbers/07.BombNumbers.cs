using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
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

            int[] bombNumer =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int specialNum = bombNumer[0];
            int power = bombNumer[1];

            bool foundNum = true;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNum)
                {
                    int leftSide = Math.Max(i - power, 0);
                    int rightSide = Math.Min(i + power, numbers.Count - 1);

                    int lenght = rightSide - leftSide + 1;
                    numbers.RemoveRange(leftSide, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
            
           
        }
    }
}
