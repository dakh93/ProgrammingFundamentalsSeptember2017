using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();

            int personAge = int.Parse(Console.ReadLine());

            int ticketPrice = 0;
            if (personAge < 0 || personAge > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            else
            {

                //WEEKDAY
                if (dayType == "Weekday")
                {
                    if (personAge >= 0 && personAge <= 18)
                    {
                        ticketPrice = 12;
                    }
                    else if (personAge >= 19 && personAge <= 64)
                    {
                        ticketPrice = 18;
                    }
                    else if (personAge <= 65 && personAge >= 122)
                    {
                        ticketPrice = 12;
                    }

                }
                    //Weekend
                 if (dayType == "Weekend")
                 {
                     if (personAge >= 0 && personAge <= 18)
                     {
                         ticketPrice = 15;
                     }
                     else if (personAge >= 19 && personAge <= 64)
                     {
                         ticketPrice = 20;
                     }
                     else if (personAge >= 65 && personAge <= 122)
                     {
                         ticketPrice = 15;
                     }
                 }
                 //Holiday
                 if (dayType == "Holiday")
                 {
                     if (personAge >= 0 && personAge <= 18)
                     {
                         ticketPrice = 5;
                     }
                     else if (personAge >= 19 && personAge <= 64)
                     {
                         ticketPrice = 12;
                     }
                     else if (personAge >= 65 && personAge <= 122)
                     {
                         ticketPrice = 10;
                     }
                 }
                 Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
