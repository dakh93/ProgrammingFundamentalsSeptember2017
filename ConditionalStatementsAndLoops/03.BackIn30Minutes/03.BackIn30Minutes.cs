using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 30;

            if (newMinutes > 59)
            {
                hours++;
                newMinutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{newMinutes:D2}");
        }
    }
}
