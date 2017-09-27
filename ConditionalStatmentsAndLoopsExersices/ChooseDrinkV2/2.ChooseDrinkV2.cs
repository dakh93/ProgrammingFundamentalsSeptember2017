using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrinkV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            double totalPrice;

            if (profession == "Athlete")
            {
                totalPrice = water * quantity;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = coffee * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = beer * quantity;
            }
            else
            {
                totalPrice = tea * quantity;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
