using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            NumToPowerCalculation(number, power);
        }

        static void NumToPowerCalculation(double number, double power)
        {
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}
