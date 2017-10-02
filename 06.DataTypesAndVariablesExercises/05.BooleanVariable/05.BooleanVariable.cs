using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkBoolValue = Console.ReadLine();

            bool checkResult = Convert.ToBoolean(checkBoolValue);

            if (checkResult == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

           
        }
    }
}
