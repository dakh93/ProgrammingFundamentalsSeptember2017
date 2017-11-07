using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftuniCoffeeOrders
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 0; i < orders; i++)
            {

                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                string dateInput = Console.ReadLine();
                DateTime date  =
                    DateTime.ParseExact(dateInput, "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleNum = long.Parse(Console.ReadLine());

                int dayInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                decimal orderPrice = dayInMonth * capsuleNum * capsulePrice;
                result += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${result:f2}");

        }
    }
}
