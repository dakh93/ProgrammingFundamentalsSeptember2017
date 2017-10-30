using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBase10toBaseN
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BigInteger[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();

            BigInteger baseToConvertTo = input[0];
            BigInteger number = input[1];

            StringBuilder resultBase = new StringBuilder();
            string divisionResult = String.Empty; 
            
            while (number != 0)
            {
                divisionResult += (number % baseToConvertTo).ToString();
                number = number / baseToConvertTo;
            }
            char[] reversing = divisionResult.ToCharArray();
            for (int i = reversing.Length - 1; i >= 0; i--)
            {
                resultBase.Append(reversing[i]);
            }

            Console.WriteLine(resultBase);
        }
    }
}
