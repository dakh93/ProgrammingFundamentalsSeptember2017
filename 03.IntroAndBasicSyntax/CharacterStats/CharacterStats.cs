using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

           
            Console.WriteLine($"Name: {playerName}");
            //HEALTH DRAWING
            Console.Write($"Health: ");
            Console.Write("|");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', maximumHealth - currentHealth));
            Console.WriteLine("|");

            //ENERGY DRAWING
            Console.Write($"Energy: ");
            Console.Write("|");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maximumEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
