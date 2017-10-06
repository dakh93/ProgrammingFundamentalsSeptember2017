using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            GetMaxOfNums(firstNum, secondNum, thirdNum);


        }

        static void GetMaxOfNums(int firstNum, int secondNum, int thirdNum)
        {
            int biggestNum = 0;

            biggestNum =Math.Max(firstNum, secondNum);
            biggestNum = Math.Max(biggestNum, thirdNum);
            Console.WriteLine(biggestNum);
        }
    }
}
