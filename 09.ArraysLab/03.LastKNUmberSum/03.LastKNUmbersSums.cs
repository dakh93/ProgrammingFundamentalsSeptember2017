using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNUmbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sumOfprevious = int.Parse(Console.ReadLine());

            int[] result =  SumSequencePrint(numbers,sumOfprevious);
            Console.WriteLine(String.Join(" ", result));
        }

        static int [] SumSequencePrint(int numbers, int previous)
        {
            int[] array = new int[numbers];
            array[0] = 1;
            int sum = array[0];

            if (previous > 1)
            {
                for (int i = 1; i < numbers; i++)
                {
                    if (i < previous)
                    {
                        array[i] = sum + array[i];
                        sum = array[i] + sum;
                    }
                    else
                    {
                        for (int j = i - 1; j >= i - previous; j--)
                        {
                        
                            array[i] += array[j];
                        }
                    
                    }
                
                }

            }
          
            return array;

        }
    }
}
