using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainnigHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int neededItems = int.Parse(Console.ReadLine());
            double totalMoney = 0.0;
            for (int i = 1; i <= neededItems; i++)
            {
                string itemName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int countOfItem = int.Parse(Console.ReadLine());

                totalMoney += price * countOfItem;
                string plural = string.Empty;
                if (countOfItem > 1)
                {
                    plural = "s";
                }
                Console.WriteLine($"Adding {countOfItem} {itemName}{plural} to cart.");
            }
            Console.WriteLine($"Subtotal: ${totalMoney:f2}");
            
            if (budget >= totalMoney)
            {
                double leftMoney = budget - totalMoney;
                Console.WriteLine($"Money left: ${leftMoney:f2}");

            }
            else
            {
                double moneyNeeded = totalMoney - budget;
                Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
            }
        }
    }
}
