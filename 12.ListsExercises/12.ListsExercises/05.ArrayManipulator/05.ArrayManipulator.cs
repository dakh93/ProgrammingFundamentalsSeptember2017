using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            string[] command = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandToDo = command[0];

            while (commandToDo != "print")
            {
                if (commandToDo == "add")
                {
                    int index = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(index, position);
                }
                else if (commandToDo == "addMany")
                {
                   numbers.InsertRange(int.Parse(command[1]),
                       command.Skip(2).Select(int.Parse).ToArray());
                }
                else if (commandToDo == "contains")
                {
                        int checkForNum = int.Parse(command[1]);
                        Console.WriteLine(numbers.IndexOf(checkForNum));
                }
                else if (commandToDo == "remove")
                {
                    int removeNum = int.Parse(command[1]);
                    numbers.RemoveAt(removeNum);
                }
                else if (commandToDo == "shift")
                {
                    int shift =int.Parse(command[1]);
                    shift %= numbers.Count;
                    for (int i = 0; i < shift; i++)
                    {
                         numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (commandToDo == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        int sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                    
                }

                command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                commandToDo = command[0];

            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
