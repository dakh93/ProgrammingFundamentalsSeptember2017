using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RestaurantDiscout
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageWanted = Console.ReadLine();

            int price = 0;
            string hall = string.Empty;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize >50 && groupSize <=100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            int discountPercent = 0;
            if (packageWanted == "Normal")
            {
                discountPercent = 5;
                price += 500;
            }
            else if (packageWanted == "Gold")
            {
                discountPercent = 10;
                price += 750;
            }
            else if (packageWanted == "Platinum")
            {
                discountPercent = 15;
                price += 1000;
            }

            double discountedPrice = price - ((price * discountPercent) / 100);
            double pricePerPerson = discountedPrice / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
