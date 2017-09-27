using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
                int cheeseCalories = 500;
                int tomatoCalories = 150;
                int salamiCalories = 600;
                int pepperCalories = 50;
                int totalCalories = 0;

            for (int i = 1; i <= numberOfIngredients; i++)
            {

                string ingredient = Console.ReadLine().ToLower();


                if (ingredient == "cheese")
                {
                    totalCalories += cheeseCalories;
                }
                else if (ingredient == "tomato sauce")
                {
                    totalCalories += tomatoCalories;
                }
                else if (ingredient == "salami")
                {
                    totalCalories += salamiCalories;
                }
                else if (ingredient == "pepper")
                {
                    totalCalories += pepperCalories;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
