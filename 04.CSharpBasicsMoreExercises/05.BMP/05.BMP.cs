using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BMP
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMin = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = Math.Round((double)numberOfBeats / 4 , 1);

            int time = (numberOfBeats * 60) / beatsPerMin;
            int minutes = time / 60; 
            int seconds = time % 60;
               
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
