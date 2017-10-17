﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
             List<double> result =  numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
