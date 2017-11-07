using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int runnersNum = int.Parse(Console.ReadLine());
            int lapsPerRunner = int.Parse(Console.ReadLine());
            int trackLenght = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            int maxRunners = trackCapacity * marathonDays;

            int totalRunnersPerMarathon = 0;

            if (runnersNum >= maxRunners)
            {
                totalRunnersPerMarathon = maxRunners;
            }
            else
            {
                totalRunnersPerMarathon = runnersNum;
            }

            
            long totalMeters = (long)totalRunnersPerMarathon * trackLenght * lapsPerRunner;
            decimal convertToKm = totalMeters / 1000;

            decimal moneyRaised = convertToKm * (decimal)moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
