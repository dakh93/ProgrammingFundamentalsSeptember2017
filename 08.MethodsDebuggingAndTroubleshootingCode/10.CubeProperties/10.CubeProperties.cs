using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameterToFind = Console.ReadLine();
            double result = 0.0d;
            if (parameterToFind == "face")
            {
              result = CubeFaceDiagpmalsCalculate(cubeSide);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameterToFind == "space")
            {
               result = CubeSpaceCalculate(cubeSide);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameterToFind == "volume")
            {
              result =  CubeVolumeCalculate(cubeSide);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameterToFind == "area")
            {
                result = CubeAreaCalculate(cubeSide);
                Console.WriteLine($"{result:f2}");
            }
        }

        static double CubeAreaCalculate(double cubeSide)
        {
            double areaResult = 6 * Math.Pow(cubeSide, 2);
            return areaResult;
        }

        static double CubeVolumeCalculate(double cubeSide)
        {
            double volumeResult = Math.Pow(cubeSide, 3);
            return volumeResult;
        }

        static double CubeSpaceCalculate(double cubeSide)
        {
            double spaceResult = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return spaceResult;
        }

        static double CubeFaceDiagpmalsCalculate(double cubeSide)
        {
            double faceResult = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return faceResult;
        }
    }
}
