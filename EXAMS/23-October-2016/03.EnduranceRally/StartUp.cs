using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] names =
                Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            decimal[] trackLayout =
                Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToArray();

            int[] checkpointIndex =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string currDriver = names[i];
                decimal currFuel = currDriver.ToCharArray().First();

                for (int currIndex = 0; currIndex < trackLayout.Length; currIndex++)
                {
                    
                    if (checkpointIndex.Any(x => x.Equals(currIndex)))
                    {
                        currFuel += trackLayout[currIndex];
                    }
                    else
                    {
                        currFuel -= trackLayout[currIndex];
                    }
                    if (currFuel <= 0)
                    {
                        Console.WriteLine($"{currDriver} - reached {currIndex}");
                        break;
                    }
                }
                if (currFuel > 0)
                {
                    Console.WriteLine($"{currDriver} - fuel left {currFuel:f2}");
                }
            }

        }
    }
}
