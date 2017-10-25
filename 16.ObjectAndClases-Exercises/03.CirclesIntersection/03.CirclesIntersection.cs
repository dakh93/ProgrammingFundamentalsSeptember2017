using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class Program
    {
       
        class Circle
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Radius { get; set; }
        }
        static void Main(string[] args)
        {
            double[] firstCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double[] secondCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Circle first = new Circle();
            first.X = firstCircle[0];
            first.Y = firstCircle[1];
            first.Radius = firstCircle[2];


            Circle second = new Circle();
            second.X = secondCircle[0];
            second.Y = secondCircle[1];
            second.Radius = secondCircle[2];


           bool intersect =  isThereIntersection(second, first);

            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static bool isThereIntersection(Circle second, Circle first)
        {
            
            double distance = Math.Sqrt(
                Math.Pow(second.X - first.X, 2) +
                Math.Pow(second.Y - first.Y, 2));

            double sumOfRad = first.Radius + second.Radius;

            if (distance <= sumOfRad)
            {
                return true;
            }
            else if(distance > sumOfRad)
            {
                return false;
            }
            return false;

        }
    }
}
