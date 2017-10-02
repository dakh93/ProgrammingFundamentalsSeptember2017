using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToConvert = int.Parse(Console.ReadLine());

            string hexResult = Convert.ToString(numberToConvert, 16).ToUpper();
            string binaryResult = Convert.ToString(numberToConvert, 2);

            Console.WriteLine(hexResult);
            Console.WriteLine(binaryResult);
        }
    }
}
