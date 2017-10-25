using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"..\..\input.txt");

            foreach (var firstLine in text)
            {
                
                PrintIndexOfLetters(firstLine);
            }



        }

        private static void PrintIndexOfLetters(string text)
        {
            char[] letterArray = text.ToCharArray();

            for (int i = 0; i < letterArray.Length; i++)
            {
                int letterIndex = letterArray[i] - 97;
                File.AppendAllText(@"..\..\output.txt",
                    letterArray[i] + "->" + letterIndex + Environment.NewLine);
            }

            string splitResults = "-----------------";
            File.AppendAllText(@"..\..\output.txt",splitResults + Environment.NewLine);


        }
    }
}
