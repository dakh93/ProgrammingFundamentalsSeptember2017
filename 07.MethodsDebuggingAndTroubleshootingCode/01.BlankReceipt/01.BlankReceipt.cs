using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

         static void PrintReceipt()
         {
             PrintHeader();
             PrintMainPart();
             PrintFooter();
         }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintMainPart()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
