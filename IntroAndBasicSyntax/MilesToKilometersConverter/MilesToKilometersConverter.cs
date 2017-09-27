using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometersConverter
{
    class MilesToKilometersConverter
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double mileToKilometer = 1.60934;

            double kilometerResult = miles * mileToKilometer;

            Console.WriteLine($"{kilometerResult:F2}");
        }
    }
}
