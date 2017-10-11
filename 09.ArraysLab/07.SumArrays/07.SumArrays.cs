using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            int[] secondArray =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int bigArray = Math.Max(firstArray.Length, secondArray.Length);
            int[] array;
            int lamp = 0;

            int[] sum = new int[bigArray];
            if (firstArray.Length != secondArray.Length)
            {
                
                if (firstArray.Length != bigArray)
                {
                    array = GetSameLenghtArray(firstArray, bigArray);
                
                }
                else
                {
                    array = GetSameLenghtArray(secondArray, bigArray);
                    lamp = 1;
                }


                for (int i = 0; i < bigArray; i++)
                {
                    if (lamp == 0)
                    {
                        sum[i] = secondArray[i] + array[i];
                    }
                    else
                    {
                        sum[i] = firstArray[i] + array[i];
                    }

                    Console.Write($"{sum[i]} ");
                }
                Console.WriteLine();

            }
            else
            {
                for (int i = 0; i < bigArray; i++)
                {
                    sum[i] = firstArray[i] + secondArray[i];
                    Console.Write($"{sum[i]} ");
                }
                Console.WriteLine();
            }
        }

        static int[] GetSameLenghtArray(int[] smallerArray, int bigArray)
        {
            int[] sameLenghtArray = new int[bigArray];

            if (bigArray != smallerArray.Length)
            {
                int j = 0;
                for (int i = 0; i < bigArray; i++)
                {

                    if (j == smallerArray.Length)
                    {
                        j = 0;
                    }
                    sameLenghtArray[i] = smallerArray[j];
                    j++;
                }
            }
            return sameLenghtArray;
        }
    }
}
