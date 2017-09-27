using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int combinationNum = 0;
            int lamp = 0;
            int magicNum = int.Parse(Console.ReadLine());
            int firstMagicNum = 0;
            int secondMagicNum = 0;


            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magicNum)
                    {
                        firstMagicNum = i;
                        secondMagicNum = j;
                        lamp = 1;
                    }
                        combinationNum++;
                }
            }
            if (lamp == 1)
            {
                Console.WriteLine($"Number found! {firstMagicNum} + {secondMagicNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");
            }
        }
    }
}
