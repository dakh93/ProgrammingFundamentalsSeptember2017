using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornestAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> beehives =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            List<int> hornestPower =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            long hornestSumPower = 0;
            
            foreach (var hornest in hornestPower)
            {
                hornestSumPower += hornest;
            }
            

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornestPower.Count == 0)
                {
                    break;
                }
                if (hornestSumPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] = beehives[i] - (int)hornestSumPower;
                    hornestSumPower = hornestSumPower - hornestPower.First();
                    hornestPower.Remove(hornestPower.First());
                }
            }
            if (beehives.Sum() == 0 )
            {
                foreach (var hornest in hornestPower.Where(i => i != 0))
                {
                    Console.Write($"{hornest} ");

                }
                Console.WriteLine();
            }
            else 
            {
                foreach (var bee in beehives.Where(x => x != 0))
                {
                        Console.Write($"{bee} ");
                }
                Console.WriteLine();
            }

        }
    }
}
