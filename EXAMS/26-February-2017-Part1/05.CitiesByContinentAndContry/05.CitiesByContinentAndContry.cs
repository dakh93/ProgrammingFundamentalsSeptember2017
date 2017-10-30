using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CitiesByContinentAndContry
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continent = 
                new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input =
                    Console.ReadLine()
                        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string cont = input[0];
                string currCountry = input[1];
                string currCity = input[2];


                if (!continent.ContainsKey(cont))
                {
                    
                    continent.Add(cont, new Dictionary<string, List<string>>());
                   
                }

                if (!continent[cont].ContainsKey(currCountry))
                {
                    continent[cont].Add(currCountry, new List<string>());
                  
                }
                continent[cont][currCountry].Add(currCity);
                

            }
            foreach (var conty in continent.Keys)
            {

                Console.WriteLine($"{conty}:");
                foreach (var cntry in continent[conty].Keys)
                {
                    
                    Console.Write($"  {cntry} -> ");

                    List<string> cities = new List<string>();
                    foreach (var city in continent[conty][cntry])
                    {
                        cities.Add(city);
                    }
                    Console.WriteLine(string.Join(", ", cities));
                }
            }

        }

       
    }

}
