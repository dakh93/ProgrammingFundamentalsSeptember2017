using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numHexFormat = Console.ReadLine();
            int resultNum = Convert.ToInt32(numHexFormat, 16);

            Console.WriteLine(resultNum);
        }
    }
}
