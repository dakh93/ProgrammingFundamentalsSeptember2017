using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            TriangleAreaCalculate(width, height);
        }

        static void TriangleAreaCalculate(double width, double height)
        {
            double area = (width * height) / 2;
            Console.WriteLine(area);
        }
    }
}
