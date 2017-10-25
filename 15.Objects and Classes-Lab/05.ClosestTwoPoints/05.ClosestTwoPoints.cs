using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
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
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double miniDIstance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);
                    if (distance < miniDIstance)
                    {
                        miniDIstance = distance;
                        closestTwoPoints = new Point[] {points[i], points[j]};
                    }
                }
            }
            return closestTwoPoints;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double aSide = Math.Abs(p1.X - p2.X);
            double bSide = Math.Abs(p1.Y - p2.Y);

            double cSide = Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(bSide, 2));
            return cSide;
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static void PrintPoint(Point points)
        {
            Console.WriteLine($"{points.X}, {points.Y}");
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = PointsReading();
            }
            return points;
        }

        static Point PointsReading()
        {
            int[] pointInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Point point = new Point();

            point.X = pointInfo[0];
            point.X = pointInfo[1];
            return point;
        }
    }
}
