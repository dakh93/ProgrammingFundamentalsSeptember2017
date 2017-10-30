using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();


            char[] firstChar = firstNum.TrimStart(new char[] { '0' }).ToCharArray().Reverse().ToArray();
            char secondChar = char.Parse(secondNum);

            if (secondChar == '0')
            {
                Console.WriteLine("0");
                return;
            }


            int cycles = firstChar.Length;

            StringBuilder final = new StringBuilder();

            int result = 0;
            int remainder = 0;

            

            

            for (int i = 0; i < cycles; i++)
            {
                int currFirst = firstChar[i] - '0';
                int currSecond = secondChar - '0';

                result = (currFirst * currSecond) + remainder;
                remainder = 0;

                if (result < 10)
                {
                    final.Append(result);
                }
                else
                {
                    remainder = result / 10;
                    result = result % 10;
                    final.Append(result);

                }

            }   
            
            if (remainder != 0)
            {
                final.Append(remainder);
            }
            StringBuilder finalSumm = ReverseStringBulder(final);
            Console.WriteLine(finalSumm);
        }

        static StringBuilder ReverseStringBulder(StringBuilder final)
        {
            StringBuilder reverse = new StringBuilder();

            for (int cnt = final.Length - 1; cnt >= 0; cnt--)
            {
                reverse.Append(final[cnt]);
            }
            return reverse;
        }
    }
}
