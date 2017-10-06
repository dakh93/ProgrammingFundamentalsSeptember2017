using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char bigger = GetMax(first, second);
                Console.WriteLine(bigger);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string bigger = GetMax(first, second);
                Console.WriteLine(bigger);
            }
            

        }
        //INT MAX CHECK
        static int GetMax(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
        //CHAR MAX CHECK
        static char GetMax(char first, char second)
        {
            int max = Math.Max(first, second);
            return (char)max;
        }
        //STRING MAX CHECK
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
