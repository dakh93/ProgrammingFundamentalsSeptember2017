using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rootInfo = new Dictionary<string, Dictionary<string, int>>();
            List<string> lineInputs = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                lineInputs.Add(input);
            }
            string findFile = Console.ReadLine();
            string fileNeeded = findFile.Split(' ').First();

            FillDictWithInfor(n, rootInfo, lineInputs, fileNeeded);

            string rootNeeded = findFile.Split(' ').Last();
            if (!rootInfo.ContainsKey(rootNeeded))
            {
                Console.WriteLine("No");
            }
            else
            {
                
                var sortFiles = rootInfo[rootNeeded]
                    .ToArray()
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);

                foreach (var file in sortFiles)
                {
                
                     Console.WriteLine($"{file.Key}.{fileNeeded} - {file.Value} KB");
                
                }
            }
        }

        private static void FillDictWithInfor(int n, Dictionary<string, Dictionary<string, int>> rootInfo, List<string> lineInputs, string fileNeeded)
        {
            for (int i = 0; i < n; i++)
            {
                string currLine = lineInputs[i];
                string root = currLine.Split('\\').ToArray().First();
                string[] splitTwoParts =
                    currLine.Split(new string[] { "." + fileNeeded + ";" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                if (splitTwoParts.Length < 2)
                {
                    continue;
                }

                string fileName = splitTwoParts[0].Split('\\').Last();
                string fileSize = splitTwoParts[1];

                if (rootInfo.ContainsKey(root))
                {
                    if (rootInfo[root].ContainsKey(fileName))
                    {
                        rootInfo[root][fileName] = int.Parse(fileSize);
                    }
                    else
                    {
                        rootInfo[root].Add(fileName, int.Parse(fileSize));
                    }
                }
                else
                {

                    rootInfo.Add(root, new Dictionary<string, int>());
                    rootInfo[root].Add(fileName, int.Parse(fileSize));
                }
                
            }
            
        }
    }
}
