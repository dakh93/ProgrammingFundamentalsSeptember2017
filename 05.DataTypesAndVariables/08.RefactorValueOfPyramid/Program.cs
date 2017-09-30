using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorValueOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double sum = (lenght * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", sum);

        }
    }
}

//CODE FOR REFACTORING
/*
     double dul, sh, V = 0;
    Console.Write("Length: ");
    dul = double.Parse(Console.ReadLine());
    Console.Write("Width: ");
    sh = double.Parse(Console.ReadLine());
    Console.Write("Heigth: ");
    V = double.Parse(Console.ReadLine());
    V = (dul + sh + V) / 3;
    Console.WriteLine("Pyramid Volume: {0:F2}", V);

 */
