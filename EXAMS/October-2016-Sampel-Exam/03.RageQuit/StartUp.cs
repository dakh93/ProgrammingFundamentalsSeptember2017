using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            
            StringBuilder word = new StringBuilder();
            StringBuilder count = new StringBuilder();
            StringBuilder result = new StringBuilder();

            bool inDigit = false;
            for (int i = 0; i < input.Length; i++)
            {
                char currElement = char.ToUpper(input[i]);

                if (inDigit)
                {

                    if (char.IsDigit(currElement))
                    {
                        count.Append(currElement);
                    }
                    else
                    {
                        for (int j = 0; j < int.Parse(count.ToString()); j++)
                        {
                            result.Append(word);
                        }
                
                        inDigit = false;
                        word.Clear();
                        word.Append(currElement);
                    }
                }
                else
                {
                    if (!char.IsDigit(currElement))
                    {
                        word.Append(currElement);
                    }
                    else
                    {
                        
                        inDigit = true;
                        count.Clear();
                        count.Append(currElement); 
                    }
                }
                
            }
            for (int j = 0; j < int.Parse(count.ToString()); j++)
            {
                result.Append(word);
            }

            Dictionary<char, bool> charOccurs = new Dictionary<char, bool>();
            foreach (var ch in result.ToString())
            {
                charOccurs[ch] = true;
            }
            var uniquChars = charOccurs.Keys.Count;

            Console.WriteLine($"Unique symbols used: {uniquChars}");
            Console.WriteLine(result.ToString());
        }
    }
}
