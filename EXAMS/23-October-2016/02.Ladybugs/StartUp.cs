using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int fieldLenght = int.Parse(Console.ReadLine());
            int[] bugsIndexes =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


            int[] field = new int[fieldLenght];



            foreach (var index in bugsIndexes)
            {
                if (!(index > field.Length - 1))
                {
                    
                    field[index] = 1;
                }
            }
            string command = Console.ReadLine();
            string[] input =
                command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (command != "end")
            {
                
                string direction = input[1];
                try
                {

                    long indexAt = long.Parse(input[0]);
                    long indexToMove = long.Parse(input[2]);
                    if (field[indexAt].Equals(1))
                    {
                        if ((indexAt < field.Length - 1) && indexAt >= 0)
                        {
                    //FIRST TWO TEST INCLUDE 

                            int firstFound = Array.IndexOf(field, 0, (int)indexToMove);
                            field[indexAt] = 0;

                            if (direction == "right" && field[indexAt + indexToMove] == 0)
                            {
                                field[indexAt + indexToMove] = 1;
                            }
                            else
                            {
                                field[firstFound] = 1;
                            }
                            
                            

                            if (direction.Equals("left") && field[indexAt + indexToMove] == 0)
                            {
                                field[indexAt + indexToMove] = 1;
                            }
                            else
                            {
                                field[firstFound] = 1;
                            }

                        }
                        else
                        {
                            field[indexAt] = 0;
                        }
                    }
                    command = Console.ReadLine();
                    input =
                        command
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }

            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}