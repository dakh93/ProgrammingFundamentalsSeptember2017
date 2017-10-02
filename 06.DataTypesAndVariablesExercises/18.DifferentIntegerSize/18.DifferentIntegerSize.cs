using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string exceptionNum = Console.ReadLine();
            try
            {
                long  number = long.Parse(exceptionNum);
                

                try
                {
                   
                    Console.WriteLine($"{number} can fit in:");
                    if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (number >= byte.MinValue && number <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (number >= short.MinValue && number <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (number >= ushort.MinValue && number <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (number >= int.MinValue && number <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (number >= uint.MinValue && number <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (number >= long.MinValue && number <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                

                }
                catch (Exception)
                {

                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{exceptionNum} can't fit in any type");
               

            }
            
        }
    }
}
