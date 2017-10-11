﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers =
                Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

            RoundNumsAwayFromZeroStyle(numbers);
        }

        static void RoundNumsAwayFromZeroStyle(double[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number,MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
