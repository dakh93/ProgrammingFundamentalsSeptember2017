using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
                
            int characterNum = int.Parse(Console.ReadLine());
            int resultLetterPosition;
            string resultString = string.Empty;

            // ONE DIGIT
            int[] oneDigits = {2, 3, 4, 5, 6, 7, 8, 9 };
            string[] oneDigitsLetter = { "a", "d", "g", "j", "m", "p", "t", "w"};

            //TWO DIGITs
            int[] twoDigits = { 22, 33, 44, 55, 66, 77, 88, 99 };
            string[] twoDigitsLetter = { "b", "e", "h", "k", "n", "q", "u", "x" };

            //THREE DIGITs
            int[] threeDigits = {222, 333, 444, 555, 666, 777, 888, 999 };
            string[] threeDigitsLetter = { "c", "f", "i", "l", "o", "r", "v", "y" };

            //FOUR DIGITs
            int[] fourDigits = { 7777, 9999 };
            string[] fourDigitsLetter = { "s", "z" };

            for (int i = 1; i <= characterNum; i++)
            {
                int letter = int.Parse(Console.ReadLine());

                if (letter == 0)
                {
                    resultString += " ";
                }
                if (letter ==  1)
                {
                    continue;
                }
                if (letter > 1 && letter < 10)
                {
                    resultLetterPosition = Array.IndexOf(oneDigits, letter);
                    resultString += oneDigitsLetter[resultLetterPosition];
                }
                else if (letter > 21 && letter < 100)
                {
                    resultLetterPosition = Array.IndexOf(twoDigits, letter);
                    resultString += twoDigitsLetter[resultLetterPosition];
                }
                else if (letter >221 && letter < 1000)
                {
                    resultLetterPosition = Array.IndexOf(threeDigits, letter);
                    resultString += threeDigitsLetter[resultLetterPosition];
                }
                else if (letter > 7776 && letter < 10000)
                {
                    resultLetterPosition = Array.IndexOf(fourDigits, letter);
                    resultString += fourDigitsLetter[resultLetterPosition];
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
