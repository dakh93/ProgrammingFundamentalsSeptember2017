using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _04.HornetArmada
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] delimeters = { ' ', '=', '-', '>', ':' };
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionsByActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionsBySoldiers =
                new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                int activity = int.Parse(inputArgs[0]);
                string legionName = inputArgs[1];
                string soldierType = inputArgs[2];
                int soldierCount = int.Parse(inputArgs[3]);

                // TODO: Check for bigger activity;

                if (legionsByActivity.ContainsKey(legionName))
                {
                    if (legionsByActivity[legionName] < activity)
                    {
                        legionsByActivity[legionName] = activity;
                    }
                }
                else
                {
                    
                    legionsByActivity[legionName] = activity;
                }

                if (!legionsBySoldiers.ContainsKey(legionName))
                {
                    legionsBySoldiers[legionName] = new Dictionary<string, long>();
                }



                if (legionsBySoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsBySoldiers[legionName][soldierType] += soldierCount;
                }
                else
                {
                    legionsBySoldiers[legionName][soldierType] = soldierCount;
                }
            }

            string input = Console.ReadLine();
            if (input.Contains("\\"))
            {
                string[] outputArgs = input.Split('\\');
                int wantedActivity = int.Parse(outputArgs[0]);
                string wantedSoldierType = outputArgs[1];

                foreach (string legionName in legionsByActivity
                    .Where(kvp => kvp.Value < wantedActivity)
                    .Select(kvp => kvp.Key)
                    .Where( ln => legionsBySoldiers[ln].ContainsKey(wantedSoldierType))
                    .OrderByDescending(ln => legionsBySoldiers[ln][wantedSoldierType]))
                {
                    Console.WriteLine($"{legionName} -> {legionsBySoldiers[legionName][wantedSoldierType]}");
                }

            }
            else
            {
                string soldierType = input;

                foreach (string legionName in legionsBySoldiers
                    .Where(kvp => kvp.Value.ContainsKey(soldierType))
                    .Select(kvp => kvp.Key)
                    .OrderByDescending(ln => legionsByActivity[ln]))
                {
                    Console.WriteLine($"{legionsByActivity[legionName]} : {legionName}");
                }
            }

            
        }
    }
    
}
