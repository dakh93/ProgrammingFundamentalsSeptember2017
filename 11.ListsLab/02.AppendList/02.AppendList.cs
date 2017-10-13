using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tokens =
                Console.ReadLine()
                    .Split('|');

            List<int> result = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int [] elements =
                    tokens[i]
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < elements.Length; j++)
                {
                    result.Add(elements[j]);
                    
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
