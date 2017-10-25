using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = {'.', ',', '!', '?', ':'};
           string[] elements = File.ReadAllText(@"..\..\resource\sample_text.txt")
                .Split(' ').ToArray();

            
            List<char> symbolsFind = new List<char>();

            foreach (var element in elements)
            {
                for (int i = 0; i < element.Length; i++)
                {
                    if (symbols.Contains(element[i]))
                    {
                        symbolsFind.Add(element[i]);
                    }
                }
            }
            Console.WriteLine(String.Join(", ",symbolsFind));
        }
    }
}
