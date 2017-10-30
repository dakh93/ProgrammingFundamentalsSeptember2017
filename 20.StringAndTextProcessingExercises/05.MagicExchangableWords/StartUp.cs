using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangableWords
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine()
                .ToLower()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            char[] first = input[0].ToCharArray();
            char[] second = input[1].ToCharArray();

            
            int max = Math.Max(first.Length, second.Length);
            int min = Math.Min(first.Length, second.Length);

            if (max != first.Length)
            {
                char[] temp = first;
                first = second;
                second = temp;
            }
            Dictionary<char, char> dict = new Dictionary<char, char>();
            bool isExchangable = true;


            for (int i = 0; i < second.Length; i++)
            {
                char firstWordChar = first[i];
                char secondWordChar = second[i];

                if (!dict.ContainsKey(firstWordChar))
                {
                    dict[firstWordChar] = secondWordChar;
                    
                }
                else if (dict[firstWordChar] != secondWordChar)
                    {
                        isExchangable = false;
                        Console.WriteLine(isExchangable.ToString().ToLower());
                        return;
                    }
                    
                
            }
            for (int i = min; i < max; i++)
            {
                char firstWordChar = first[i];

                if (!dict.ContainsKey(firstWordChar))
                    {
                        isExchangable = false;
                        break;
                    }
                
               
            }

            Console.WriteLine(isExchangable.ToString().ToLower());


        }
    }
}
