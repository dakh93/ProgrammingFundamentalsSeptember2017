using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeter =
            {
                ',', ';', ':', '.', '!', '(', ')', '"', '\'',
                '\\', '/', '[', ']', ' '
            };

            List<string> text =
                Console.ReadLine()
                    .Split(delimeter,StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {

                char[] word = text[i].ToCharArray();
               
                int counter = 0;
                int lowerCount = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    

                    if (Char.IsUpper(word[j]))
                    {
                        counter++;
                    }
                    if (Char.IsLower(word[j]))
                    {
                        lowerCount++;
                    }
                    
                    

                }
                if (counter == word.Length)
                {
                    upperCase.Add(text[i]);
                }
                else if (lowerCount == word.Length)
                {
                    lowerCase.Add(text[i]);
                }
                else
                {
                    mixedCase.Add(text[i]);
                }
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
        }
    }
}
