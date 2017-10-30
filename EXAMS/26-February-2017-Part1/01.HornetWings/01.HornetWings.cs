using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceForThousand = double.Parse(Console.ReadLine());
            int enduranceBeforeRest = int.Parse(Console.ReadLine());

            int restPeriod = 5;
            int flapsPerSec = 100;

            double finalDistance = (wingFlaps / 1000) * distanceForThousand;
            int flapsToFinal = wingFlaps / flapsPerSec;
            int secondsToFinal = 
                (wingFlaps / enduranceBeforeRest) * restPeriod;

            int resultSecs = flapsToFinal + secondsToFinal;

            Console.WriteLine($"{finalDistance:f2} m.");
            Console.WriteLine($"{resultSecs} s.");
        }
    }
}
