using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSumLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int [] numbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            
            int k = numbers.Length / 4;
            

            int[] leftPart = numbers.Take(k).Reverse().ToArray();
            int[] rightPart = numbers.Reverse().Take(k).ToArray();

            int[] firstRow = leftPart.Concat(rightPart).ToArray();
            int[] secondRow = numbers.Skip(k).Take(k * 2).ToArray();

            var result =
                firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
