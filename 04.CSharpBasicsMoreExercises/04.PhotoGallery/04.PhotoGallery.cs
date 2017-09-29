using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNum = int.Parse(Console.ReadLine());

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            double photoSizeInBytes = double.Parse(Console.ReadLine());
            

            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: DSC_{photoNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minutes:D2}");
            if (photoSizeInBytes < 1000)
            {
                Console.WriteLine("Size: {0}B", photoSizeInBytes);
            }
            else if (photoSizeInBytes < 1000000)
            {
                photoSizeInBytes /= 1000;
                Console.WriteLine("Size: {0}KB", photoSizeInBytes);
            }
            else
            {
                photoSizeInBytes /= 1000000;
                Console.WriteLine("Size: {0}MB", photoSizeInBytes);
            }
            string orientation = string.Empty;
            if (photoWidth == photoHeight)
            {
                orientation = "square";
            }
            else if (photoHeight > photoWidth)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "landscape";
            }
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
        }
    }
}
