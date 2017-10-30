using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string format = "hh:mm:ss";
            TimeSpan leaveHour = 
                TimeSpan.ParseExact(input, format, CultureInfo.InvariantCulture);
        }
    }
}
