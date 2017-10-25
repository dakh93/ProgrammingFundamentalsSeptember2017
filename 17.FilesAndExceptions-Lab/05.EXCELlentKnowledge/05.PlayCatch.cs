using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EXCELlentKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int counter = 0;
            string[] command =
                Console.ReadLine()
                    .Split(' ')
                    .ToArray();

            while (true)
            {
                try
                {

                    if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        numbers[index] = element;
                    }
                    else if (command[0] == "Print")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (startIndex > endIndex)
                        {
                            throw  new IndexOutOfRangeException();
                        }
                        if (endIndex <= numbers.Length - 1)
                        {
                            string separator = ",";
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                if (i == endIndex)
                                {
                                    separator = "";
                                }
                                Console.Write($"{numbers[i]}{separator} ");
                            }
                             Console.WriteLine();
                            
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                    else if (command[0] == "Show")
                    {
                        int index = int.Parse(command[1]);
                        Console.WriteLine($"{numbers.ElementAt(index)}");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    counter++;
                }
                catch (IndexOutOfRangeException )
                {
                    Console.WriteLine("The index does not exist!");
                    counter++;
                }
                catch (FormatException )
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    counter++;
                }

                if (counter == 3)
                {
                    break;
                }
                command =
                    Console.ReadLine()
                        .Split(' ')
                        .ToArray();
                
            }
            
            
                Console.Write(String.Join(", ", numbers));
            
            Console.WriteLine();
        }
    }
}
