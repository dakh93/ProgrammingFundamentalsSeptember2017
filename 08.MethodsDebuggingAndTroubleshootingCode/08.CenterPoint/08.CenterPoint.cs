using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (Point1IsCloserToCenter(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");

            }

            ClosestPointToCenter(x1, y1, x2, y2);
        }

        private static bool Point1IsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = ClosestPointToCenter(x1, y1, 0, 0);
            double distance2 = ClosestPointToCenter(x2, y2, 0, 0);

            if (distance1 < distance2)
            {
                return true;
            }
            return false;
        }

        static double ClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
