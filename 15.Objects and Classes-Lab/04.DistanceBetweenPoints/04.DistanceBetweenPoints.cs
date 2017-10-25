using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static void Main(string[] args)
        {
            double[] firstInput =
                Console.ReadLine()
                    .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            double[] secondInput =
                Console.ReadLine()
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            Point p1 = new Point();
            {
                p1.X = firstInput[0];
                p1.Y = firstInput[1];
            }

            Point  p2 = new Point();
            {
                p2.X = secondInput[0];
                p2.Y = secondInput[1];
            }

            double result =   CalcDistance(p1, p2);
            Console.WriteLine($"{result:f3}");
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double aSide = Math.Abs(p1.X - p2.X);
            double bSide = Math.Abs(p1.Y - p2.Y);

            double cSide = Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(bSide, 2));
            return cSide;
        }
    }
}
