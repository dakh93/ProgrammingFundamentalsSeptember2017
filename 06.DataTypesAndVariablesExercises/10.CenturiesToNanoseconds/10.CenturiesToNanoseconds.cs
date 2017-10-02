using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort year = (ushort)(centuries * 100);
            uint days = (uint)(year * 365.2422);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {year} years = {days} days" +
                $" = {hours} hours = {minutes} minutes = {seconds} seconds " +
                $"= {miliseconds} milliseconds = {microseconds} microseconds " +
                $"= {nanoseconds} nanoseconds");

        }
    }
}
