using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();


            char[] firstChar = firstNum.TrimStart(new char[] { '0' }).ToCharArray().Reverse().ToArray();
            char[] secondChar = secondNum.TrimStart(new char[] { '0' }).ToCharArray().Reverse().ToArray();

            int shorter = Math.Min(firstChar.Length, secondChar.Length);
            int longer = Math.Max(firstChar.Length, secondChar.Length);

            StringBuilder final = new StringBuilder();

            int result = 0;
            int remainder = 0;

            bool areEqual = false;

            if (firstChar.Length == secondChar.Length)
            {
                areEqual = true;
            }
           
            for (int i = 0; i < shorter; i++)
            {
                int currFirst = firstChar[i] - '0';
                int currSecond = secondChar[i] - '0';
                
                result = currFirst + currSecond + remainder;
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

            if (areEqual)
            {
                if (remainder != 0)
                {
                    final.Append(remainder);
                }
                StringBuilder finalSum = ReverseStringBulder(final);
                Console.WriteLine(finalSum);
                return;
                
            }
            else
            {
                for (int i = shorter; i < longer ; i++)
                {
                    int currFirst = 0;
                    if (longer == firstChar.Length)
                    {
                        currFirst = firstChar[i] - '0';
                        
                    }
                    else
                    {
                        currFirst = secondChar[i] - '0';
                    }

                    if (remainder != 0)
                    {
                        result = currFirst + remainder;
                        if (result > 9)
                        {
                            remainder = result / 10;
                            result = result % 10;
                            final.Append(result);
                        }
                        else
                        {
                            remainder = 0;
                            final.Append(currFirst);
                        }
                    }
                    else
                    {
                        final.Append(currFirst);
                    }
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
