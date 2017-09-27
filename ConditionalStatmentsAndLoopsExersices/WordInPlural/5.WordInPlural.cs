using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            string newString = string.Empty;
            if (word.EndsWith("y") == true)
            {
                newString = word.Replace("y", "ies");
            }
            else if (word.EndsWith("o") == true ||
                word.EndsWith("ch") == true ||
                word.EndsWith("s") == true ||
                word.EndsWith("sh") == true ||
                word.EndsWith("x") == true ||
                word.EndsWith("z") == true )
                
            {
                newString = word + "es";
            }
            else
            {
                newString = word + "s";
            }
           
            Console.WriteLine(newString);
        }
    }
}
