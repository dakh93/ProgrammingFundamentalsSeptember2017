using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            char[] firstInput = input[0].ToCharArray();
            char[] secondInput = input[1].ToCharArray();


            long result = 0;
            result = MultiplyingCharsAndSumResult(firstInput, secondInput, result);

            Console.WriteLine(result);
        }

        static long MultiplyingCharsAndSumResult(char[] firstInput, char[] secondInput, long result)
        {
            int shortestInput = Math.Min(firstInput.Length, secondInput.Length);
            int longestInput = Math.Max(firstInput.Length, secondInput.Length);
            
            for (int i = 0; i < shortestInput; i++)
            {
                result += firstInput[i] * secondInput[i];
            }

            if (shortestInput == firstInput.Length)
            {
                for (int i = shortestInput; i < longestInput; i++)
                {
                    result += secondInput[i];
                }
            }
            else 
            {
                
                for (int i = shortestInput; i < longestInput; i++)
                {
                    result += firstInput[i];
                }
            }
            
            return result;
        }
    }
}
