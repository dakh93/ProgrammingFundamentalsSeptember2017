using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumLimit = int.Parse(Console.ReadLine());

            int sum = 0;
            int combinationCounter = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                   
                        sum += (i * j) * 3;
                        combinationCounter++;

                    if (sum >= sumLimit)
                    {
                        Console.WriteLine($"{combinationCounter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {sumLimit}");
                        return;
                    }
                    
                   
                }
            }
            

                Console.WriteLine($"{combinationCounter} combinations");
                Console.WriteLine($"Sum: {sum}");
            

        }
    }
}
