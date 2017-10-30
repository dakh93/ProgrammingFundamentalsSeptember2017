using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new char[] {' ', ','},StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            string[] checkText = text.Split(' ').ToArray();

            foreach (var word in banWords)
            {
                text = text.Replace(word, new string('*', word.Length));

            }
            Console.WriteLine(text);
        }
    }
}
