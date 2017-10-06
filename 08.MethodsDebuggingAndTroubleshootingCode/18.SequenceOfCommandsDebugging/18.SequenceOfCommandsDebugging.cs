using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SequenceOfCommandsDebugging
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = new string[sizeOfArray];
            command = Console.ReadLine()
                .Split(' ')
                .ToArray();
           // command[0] = " ";

            while (!command[0].Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();

                int[] parameters = new int[2];

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    //string[] stringParams = line.Split(ArgumentsDelimiter);
                    parameters[0] = int.Parse(command[1]);
                    parameters[1] = int.Parse(command[2]);

                   array =  PerformAction(array, command[0], parameters);
                    
                }
                else
                {
                   array = PerformAction(array, command[0], parameters);
                }


                PrintArray(array);
                

                command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] numbers)
        {
            long[] array = arr.Clone() as long[];
            int pos = numbers[0] - 1;
            int value = numbers[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            return array;
        }

        static long[] ArrayShiftRight(long[] array)
        {
            long temp = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                }
            }
            return array;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = 0;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
           
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
    
}
