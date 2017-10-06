﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.BePositiveDebuggin
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input =
                    Console.ReadLine()
                        .Trim()
                        .Split(' ');
                    
                List<int> numbers = new List<int>();
                
                for (int j = 0; j < input.Length; j++)
                {
                    int number;
                    bool isNum = int.TryParse(input[j], out number);
                    if (!isNum)
                    {
                        continue;
                    }
                    else
                    {
                        numbers.Add(number);
                    }
               
            }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else if (j + 1 < numbers.Count)
                    {
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    j++;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                    
                }
            }
        }
    }
}
