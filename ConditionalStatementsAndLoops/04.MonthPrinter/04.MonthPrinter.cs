using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNumber = int.Parse(Console.ReadLine());

            string[] months = new string[] {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[monthNumber - 1]);
            }

        }
    }
}
