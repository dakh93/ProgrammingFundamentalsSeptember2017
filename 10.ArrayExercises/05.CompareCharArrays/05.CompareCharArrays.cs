using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray =
                Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();

            char[] secondArray =
                Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();

            PrintSmallerInAlphabetOrded(firstArray, secondArray);
        }

        private static void PrintSmallerInAlphabetOrded(char[] firstArray, char[] secondArray)
        {
            
            int smallerLenght = Math.Min(firstArray.Length, secondArray.Length);

            bool isSmaller = false;
                if (firstArray.Length == secondArray.Length)
                {
                    isSmaller = EvenLenghtCharsCompare(firstArray, secondArray);
                    
                }
                else if (firstArray.Length > secondArray.Length )
                {
                    isSmaller = UnevenFirstArraysCheck(firstArray, secondArray);
                }
                else if (firstArray.Length < secondArray.Length)
                {
                isSmaller = UnevenSecondArraysCheck(firstArray, secondArray);
            }
                
            
            if (isSmaller == true)
            {
                Console.Write(String.Join("",firstArray));
                Console.WriteLine();
                Console.Write(String.Join("", secondArray));
                Console.WriteLine();
            }
            else
            {
                Console.Write(String.Join("", secondArray));
                Console.WriteLine();
                Console.Write(String.Join("", firstArray));
                Console.WriteLine();
            }



        }

        private static bool UnevenSecondArraysCheck(char[] firstArray, char[] secondArray)
        {
            bool isSmaller = false;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if ((int)firstArray[i] == (int)secondArray[i])
                {
                    if (i == firstArray.Length - 1)
                    {
                        isSmaller = true;
                    }
                    continue;
                }
                else if ((int)firstArray[i] < (int)secondArray[i])
                {
                    isSmaller = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            return isSmaller;
        }

        private static bool UnevenFirstArraysCheck(char[] firstArray, char[] secondArray)
        {
            bool isSmaller = false;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if ((int)firstArray[i] == (int)secondArray[i])
                {
                    continue;
                }
                else if ((int)firstArray[i] < (int)secondArray[i])
                {
                    isSmaller = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            return isSmaller;
        }

        private static bool EvenLenghtCharsCompare(char[] firstArray, char[] secondArray)
        {
            bool isSmaller = false;
            for (int i = 0; i < firstArray.Length; i++)
            {
                
                if ((int)firstArray[i] == (int)secondArray[i])
                {
                    continue;
                }
                else if ((int)firstArray[i] < (int)secondArray[i])
                {
                    isSmaller = true;
                    break;
                }
                else
                {
                    isSmaller = false;
                    break;

                }
            }
            return isSmaller;
        }
    }
}
