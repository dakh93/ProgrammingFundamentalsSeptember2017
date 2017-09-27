using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());

            int result;
            if (startNumber > 10)
            {
                result = startNumber * multiplier;
                Console.WriteLine($"{multiplier} X {startNumber} = {result}");
            }
            for (int i = startNumber; i <= 10; i ++)
            {
                
                result = multiplier * i;
                Console.WriteLine($"{multiplier} X {i} = {result}");
            }
        }
    }
}
 