using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.XFigureDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int xHeight = int.Parse(Console.ReadLine());

            //UPPER PART
            for (int i = 0; i < xHeight/2; i++)
            {
                int spaceBetween = (xHeight - 2) - (i * 2); 
                Console.Write(new string(' ',i));
                Console.Write("x");
                Console.Write(new string(' ',spaceBetween));
                Console.Write("x");
                Console.WriteLine();

            }

            //MIDDLE PART
            Console.Write(new string(' ',xHeight / 2));
            Console.WriteLine('x');

            //LOWER PART
            
            int spaceBetweenTwo = 1;
            for (int i = 1; i <= xHeight / 2; i++)
            {
                Console.Write(new string(' ',(xHeight / 2) - i ));
                Console.Write("x");
                Console.Write(new string(' ', spaceBetweenTwo ));
                Console.Write("x");
                Console.WriteLine();
                spaceBetweenTwo += 2;
            }
        }
    }
}
