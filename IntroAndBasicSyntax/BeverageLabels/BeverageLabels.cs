using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double productVolume = double.Parse(Console.ReadLine());
            double energyPerServing = double.Parse(Console.ReadLine());
            double sugarPerServing = double.Parse(Console.ReadLine());

            double totalEnergyTaken = (productVolume * energyPerServing) / 100;
            double totalSugarTaken = (productVolume * sugarPerServing) / 100;

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{totalEnergyTaken}kcal, {totalSugarTaken}g sugars");

        }
    }
}
