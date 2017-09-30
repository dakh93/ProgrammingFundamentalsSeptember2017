using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = 0;
            if (peopleNum % elevatorCapacity != 0)
            {
                courses = peopleNum / elevatorCapacity + 1;
            }
            else
            {
                courses = peopleNum / elevatorCapacity;
            }

            Console.WriteLine(courses);
        }
    }
}
