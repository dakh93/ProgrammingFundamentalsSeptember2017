using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();

            int nightsStay = int.Parse(Console.ReadLine());

            double studio = 0.0;
            double doubleRoom = 0.0;
            double suite = 0.0;
            

            if (month == "May" || month == "October")
            {
                
                doubleRoom = 65.00;
                suite = 75.00;
                studio = 50.00;

                // DISCOUT FOR STUIO ONLY
                if (nightsStay > 7)
                {
                    studio = 50.00 - ((50.00 * 5) / 100);
                }
               
            }
            else if (month == "June" || month == "September")
            {
                studio = 60.00;
                suite = 82.00;
                doubleRoom = 72.00;
                //DISCOUNT FOR DOUBLE ROOM ONLY
                if (nightsStay > 14)
                {
                    doubleRoom = 72.00 - (72.00 * 10) / 100;
                }
                
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68.00;
                doubleRoom = 77.00;
                suite = 89.00;
                //DISCOUT FOR SUITE ONLY
                if (nightsStay > 14)
                {
                    suite = 89.00 - (89.00 * 15) / 100;
                }
              
            }
            
            double doubleRoomTotal = nightsStay * doubleRoom;
            double suiteTotal = nightsStay * suite;
            double studioTotal = nightsStay * studio;
            if (nightsStay > 7 && (month == "September" || month== "October"))
            {
                studioTotal = studio * (nightsStay - 1);
              
            }

            Console.WriteLine($"Studio: {studioTotal:F2} lv.");
            Console.WriteLine($"Double: {doubleRoomTotal:F2} lv.");
            Console.WriteLine($"Suite: {suiteTotal:F2} lv.");
        }
    }
}
 