using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            ConvertFahrenheitToCelsius(fahrenheit);
        }

        static void ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double conversion = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{conversion:f2}");
        }
    }
}
