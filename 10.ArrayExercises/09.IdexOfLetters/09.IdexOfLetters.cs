using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IdexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintIndexOfLetters(text);



        }

        private static void PrintIndexOfLetters(string text)
        {
            char[] letterArray = text.ToCharArray();

            for (int i = 0; i < letterArray.Length; i++)
            {
                int letterIndex = letterArray[i] - 97;
                Console.WriteLine($"{letterArray[i]} -> {letterIndex}");
            }


        }
    }
}
