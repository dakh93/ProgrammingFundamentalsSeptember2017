using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int metalCnt = 0;
            int quantityCnt = 1;
            string[] resource = File.ReadAllText(@"..\..\input.txt")
                .Split(new [] {Environment.NewLine}, StringSplitOptions.None)
                .ToArray();
            
            string metal = resource[metalCnt];
            
            if (metal == "stop")
            {
                return;
            }
            decimal quantity = decimal.Parse(resource[quantityCnt]);

            Dictionary<string, decimal> metals = new Dictionary<string, decimal>();

            while ( metal != "stop")
            {
                if (metals.ContainsKey(metal))
                {
                    metals[resource[quantityCnt]] += quantity;
                }
                else
                {
                    metals.Add(resource[metalCnt], quantity);
                }
                if (metal == "stop")
                {
                    break;
                }

                metalCnt += 2;
                quantityCnt += 2;
                metal = resource[metalCnt];
                if (metal == "stop")
                {
                    break;
                }

                quantity = decimal.Parse(resource[quantityCnt]);
            }

            foreach (var element in metals)
            {
                File.AppendAllText(@"..\..\output.txt",
                    element.Key + " -> " + element.Value + Environment.NewLine);
            }
            string separatorOfDiffInputs = "-------------------";
            File.AppendAllText(@"..\..\output.txt",separatorOfDiffInputs + Environment.NewLine);
        }

        
    }
}
