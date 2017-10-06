using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SubstringDebigging
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1;
                    string matchedString = string.Empty;
                    if (i + endIndex <= text.Length)
                    {
                        matchedString = text.Substring(i, endIndex);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }
                    
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
