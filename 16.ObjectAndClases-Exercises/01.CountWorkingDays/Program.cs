using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class BookLibrary
    {
        static void Main(string[] args)
        {

            string start = Console.ReadLine();
            string end = Console.ReadLine();

            var startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);


            DateTime[] officialHolidays = new DateTime[12];
            {
                officialHolidays[0] = new DateTime(4, 01, 01);
                officialHolidays[1] = new DateTime(4, 03, 03);
                officialHolidays[2] = new DateTime(4, 05, 01);
                officialHolidays[3] = new DateTime(4, 05, 06);
                officialHolidays[4] = new DateTime(4, 05, 24);
                officialHolidays[5] = new DateTime(4, 09, 06);
                officialHolidays[6] = new DateTime(4, 09, 22);
                officialHolidays[7] = new DateTime(4, 11, 01);
                officialHolidays[9] = new DateTime(4, 12, 24);
                officialHolidays[10] = new DateTime(4, 12, 25);
                officialHolidays[11] = new DateTime(4, 12, 26);


            };
            int workDaysCount = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool isHoliday = officialHolidays.Any
                    (d => d.Day == i.Day &&
                    d.Month == i.Month);
                if (!isHoliday && 
                    i.DayOfWeek != DayOfWeek.Saturday &&
                    i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workDaysCount++;

                }
               
            }
            Console.WriteLine(workDaysCount);




        }
    }
}
