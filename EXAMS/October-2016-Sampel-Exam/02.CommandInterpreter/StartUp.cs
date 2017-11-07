using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// THE TASK IS NOT COMPLETELY DONE
namespace _02.CommandInterpreter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] commandInput =
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int startIndex = 0;
            int endIndex = 0;

            List<string> currList = new List<string>();
            while (commandInput[0] != "end")
            {
                try
                {
                    //IF REVERSE
                    if (commandInput[0].Equals("reverse"))

                    {
                        startIndex = int.Parse(commandInput[2]);
                        endIndex = int.Parse(commandInput[4]);

                        if (startIndex < 0 || startIndex >= input.Count ||
                            (startIndex + endIndex) > input.Count || endIndex < 0)
                        {
                            throw new Exception();
                        }

                        currList = input.Skip(startIndex).Take(endIndex).Reverse().ToList();
                        input.RemoveRange(startIndex, endIndex);
                        input.InsertRange(startIndex, currList);

                    }
                    //IF SORT
                    else if (commandInput[0].Equals("sort"))
                    {
                        startIndex = int.Parse(commandInput[2]);
                        endIndex = int.Parse(commandInput[4]);

                        if (startIndex < 0 || startIndex >= input.Count ||
                            (startIndex + endIndex) > input.Count || endIndex < 0)
                        {
                            throw new Exception();
                        }

                        currList = input.Skip(startIndex).Take(endIndex).OrderBy(x => x).ToList();
                        input.RemoveRange(startIndex, endIndex);
                        input.InsertRange(startIndex, currList);

                    }
                    else if (commandInput[0].Equals("rollLeft"))
                    {
                        int rollTimes = int.Parse(commandInput[1]);
                        if (rollTimes < 0)
                        {
                            throw new Exception();
                        }
                        currList = input.Take(rollTimes).ToList();
                        input.RemoveRange(0, rollTimes);
                        input.InsertRange(input.Count, currList);

                    }
                    else if (commandInput[0].Equals("rollRight"))
                    {
                        int rollTimes = int.Parse(commandInput[1]);
                        if (rollTimes < 0)
                        {
                            throw new Exception();
                        }
                        int start = input.Count - rollTimes;
                        currList = input.Skip(start).Take(rollTimes).ToList();
                        input.RemoveRange(start, rollTimes);
                        input.InsertRange(0, currList);
                    }
                    else
                    {
                        throw new Exception();
                    }


                    commandInput = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input parameters.");
                    commandInput = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
