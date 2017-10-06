using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            GetFigureArea(figureType);
        }

        static void GetFigureArea(string figureType)
        {
            double result = 0.0d;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = CalculateTriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());

                result = CalculateSquareArea(squareSide);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result =CalculateRectangleArea(width, height);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                result =CalculateCircleArea(radius);
            }
            Console.WriteLine($"{result:f2}");
        }

        static double CalculateCircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            double recArea = width * height;
            return recArea;
        }

        static double CalculateSquareArea(double squareSide)
        {
            double squareArea = squareSide * squareSide;
            return squareArea;
        }

        static double CalculateTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
    }
}
