using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (double element in nums)
            {

                if (counts.ContainsKey(element))
                {
                    counts[element]++;
                }
                else
                {
                    counts[element] = 1;
                }
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
