using System;


namespace _01.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
           
            uint pokePower = uint.Parse(Console.ReadLine());
            uint distanceToPoke = uint.Parse(Console.ReadLine());
            byte exhaustFactor = byte.Parse(Console.ReadLine());

            int pokeCounter = 0;
            uint startPower = pokePower;
            while (pokePower >= distanceToPoke)
            {

                if (pokePower == ((startPower * 50) / 100) && pokePower > exhaustFactor)
                {
                    pokePower /= exhaustFactor;
                }
                else
                {
                    
                    uint temp = pokePower - distanceToPoke;
                    pokePower = temp;
                    pokeCounter++;
                    
                }
            }
            
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);

        }
    }
}
