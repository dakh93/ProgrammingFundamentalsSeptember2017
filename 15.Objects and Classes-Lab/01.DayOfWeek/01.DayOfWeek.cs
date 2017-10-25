using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
