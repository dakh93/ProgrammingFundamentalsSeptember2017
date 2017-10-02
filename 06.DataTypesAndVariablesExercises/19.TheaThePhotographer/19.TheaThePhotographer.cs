using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTimeSecs = long.Parse(Console.ReadLine());
            long filteFactorForUpload = long.Parse(Console.ReadLine());
            long filteredPictureUploadTime = long.Parse(Console.ReadLine());
            
            long usefulPictures = (long)Math.Ceiling((numberOfPictures * filteFactorForUpload) / 100d) ;
            long totalFilterSecs = numberOfPictures * filterTimeSecs;
            long choosenPictureUploadTime = usefulPictures * filteredPictureUploadTime;
            long totalTimeNeeedSecs = totalFilterSecs + choosenPictureUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeNeeedSecs);
            

            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
        }
    }
}
