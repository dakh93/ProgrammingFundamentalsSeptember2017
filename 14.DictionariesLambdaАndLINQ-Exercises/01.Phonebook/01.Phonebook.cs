using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            string entry = command[0];

            Dictionary<string, string> people = new Dictionary<string, string>();
            while (entry != "END")
            {

                if (entry == "A")
                {
                    string name = command[1];
                    string phone = command[2];
                    people[name] = phone;
                    
                }
                else if (entry == "S")
                {
                    
                    string name = command[1];
                    if (people.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {people[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exists.");
                    }
                }
                command =
                    Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                entry = command[0];
            }
        }
    }
}
