using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =
                Console.ReadLine()
                    .ToLower()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Dictionary<string, int> occurCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (occurCount.ContainsKey(word))
                {
                    occurCount[word]++;
                }
                else
                {
                    occurCount[word] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var num in occurCount)
            {
                if (num.Value % 2 != 0)
                {
                    result.Add(num.Key);
                }
            }
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
