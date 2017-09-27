using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            Console.WriteLine($"Adding ingredient {ingredient}.");

            int counter = 1;
            
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    goto EndWhile;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }
            EndWhile:
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
