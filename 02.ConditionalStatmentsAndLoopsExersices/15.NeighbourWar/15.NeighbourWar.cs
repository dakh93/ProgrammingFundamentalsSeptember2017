using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int roundCounter = 1;
            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if (roundCounter % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0 || peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                { 
                    peshoHealth -= goshoDamage;
                    if (goshoHealth <= 0 || peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                
                if (roundCounter % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                roundCounter++;

            }
            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {roundCounter}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {roundCounter}th round.");

            }
        }
    }
}
;