﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

           
            int counter = 0;
            try
            {

                while (counter <= 100)
                {
                     int number = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                
                Console.WriteLine(counter);
                return;
            }
            Console.WriteLine(counter);

        }
    }
        
}
