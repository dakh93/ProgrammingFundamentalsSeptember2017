using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstColumn = int.Parse(Console.ReadLine());
            int secondColumn = int.Parse(Console.ReadLine());
            int thirdolumn = int.Parse(Console.ReadLine());
            int fourthColumn = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstColumn:D4} {secondColumn:D4} {thirdolumn:D4} {fourthColumn:D4}");
        }
    }
}
