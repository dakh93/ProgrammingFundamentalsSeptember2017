using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            if (resource == "stop")
            {
                return;
            }
            decimal quantity = decimal.Parse(Console.ReadLine());
            Dictionary<string, decimal> metals = new Dictionary<string, decimal>();

            while (resource != "stop")
            {
                if (metals.ContainsKey(resource))
                {
                    metals[resource] += quantity;
                }
                else
                {
                     metals.Add(resource, quantity);
                }
                if (resource == "stop")
                {
                    break;
                }

                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                quantity = decimal.Parse(Console.ReadLine());
            }

            foreach (var metal in metals)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}
