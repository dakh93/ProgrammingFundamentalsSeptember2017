using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBaseNToBase10
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            
            BigInteger[] input =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();

            BigInteger baseToConvertTo = input[0];
            BigInteger number = input[1];
            string reversed = string.Empty;
            while (number != 0)
            {
                reversed += number % 10;
                number /= 10;
            }
            char[] digits = reversed.ToArray();
            StringBuilder resultBase = new StringBuilder();
            BigInteger result = 0;
            
            BigInteger powered = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                int num = digits[i] - '0';
                
                
                result += num * BigInteger.Pow(baseToConvertTo, i);
            }



            Console.WriteLine(result);
            
        }
    }
}
