using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double steps = double.Parse(Console.ReadLine()) % 86400;
            double secPerStep = double.Parse(Console.ReadLine())% 86400;

            string format = "H:m:s";
            DateTime leaveHour = 
                DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            double secondsTotal = steps * secPerStep;

            DateTime resulteTime = leaveHour.AddSeconds(secondsTotal);

            Console.WriteLine($"Time Arrival: {resulteTime.TimeOfDay}");


        }
    }
}
