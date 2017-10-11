using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =
                Console.ReadLine()
                    .Split(' ')
                    .ToArray();

            for (int i = array.Length -1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        
    }
}
