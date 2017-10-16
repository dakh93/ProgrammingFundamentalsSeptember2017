using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            string[] command = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Odd" && command[0] !="Even")
            {

                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(num => num == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, index);
                }

                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                {
                    evens.Add(element);
                }
                else
                {
                    odds.Add(element);
                }
            }

            if (command[0] == "Even")
            {
                Console.WriteLine(String.Join(" ", evens));
            }
            else
            {
                Console.WriteLine(String.Join(" ", odds));
            }
        }
    }
}
