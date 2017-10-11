using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
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

            GetTripleSum(numbers);
        }

        static void GetTripleSum(int[] numbers)
        {
            int sum = 0;
            bool foundSum = false;
            for (int firstNum = 0; firstNum < numbers.Length; firstNum++)
            {
                for (int secondNum = 0; secondNum < numbers.Length; secondNum++)
                {
                    for (int sumNumber = 0; sumNumber < numbers.Length; sumNumber++)
                    {
                        sum = numbers[firstNum] + numbers[secondNum];
                        if (firstNum >= 0 && firstNum < secondNum && sum == numbers[sumNumber])
                        {
                            Console.WriteLine($"{numbers[firstNum]} + {numbers[secondNum]} == {numbers[sumNumber]}");
                            foundSum = true;
                            break;
                        }
                    }
                }

            }
                if (foundSum == false) 
                {
                    Console.WriteLine("No");
                }
        }
    }
}
