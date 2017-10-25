using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePositions
{
    class Program
    {
        class Rectangle
        {
            public double Left { get; set; }
            public double Top { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public double CalcArea()
            {
                return Width * Height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle first = new Rectangle();
            Rectangle second = new Rectangle();

            for (int i = 0; i < 2; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                GetRectanglePoints(input, i, first, second);
            }

        }

        static void GetRectanglePoints(int[] input, int i, Rectangle first, Rectangle second)
        {
                if (i == 0)
                {
                    
                    first.Left = input[0];
                    first.Top = input[1];
                    first.Width = input[2];
                    first.Height = input[3];
                }
                else
                {
                    second.Left = input[0];
                    second.Top = input[1];
                    second.Width = input[2];
                    second.Height = input[3];
                }
            
        }
    }
}
