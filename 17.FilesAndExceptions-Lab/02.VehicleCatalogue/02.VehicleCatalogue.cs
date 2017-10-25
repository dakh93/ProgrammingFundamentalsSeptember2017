using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehicleCatalogue
{
    class Vehicle
    {
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            List<Vehicle> vehicles = new List<Vehicle>();
            while (input[0] != "End")
            {
                ChangeFirstLetterToCapital(input);

                Vehicle curVehicle = new Vehicle();

                curVehicle.VehicleType = input[0];
                curVehicle.Model = input[1];
                curVehicle.Color = input[2].ToLower();
                curVehicle.Horsepower = double.Parse(input[3]);

                vehicles.Add(curVehicle);
                input =
                    Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
            }
            PrintVehicleOfCatalogue(vehicles);

            PrintAverageHorsepower(vehicles);
        }

        static void ChangeFirstLetterToCapital(string[] input)
        {
            
            char[] letters = input[0].ToLower().ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            string ready = new string(letters);
            input[0] = ready;
            
        }

        static void PrintAverageHorsepower(List<Vehicle> vehicles)
        {
            double carHpSum = 0;
            double truckHpSum = 0;
            double carCnt = 0;
            double truckCnt = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.VehicleType.ToLower() == "car")
                {
                    carHpSum += vehicle.Horsepower;
                    carCnt++;
                }
                else
                {
                    truckHpSum += vehicle.Horsepower;
                    truckCnt++;
                }
            }
            if (carCnt > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carHpSum/carCnt):f2}."); 
                
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");

            }
            if (truckCnt > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(truckHpSum/truckCnt):f2}."); 
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }

        static void PrintVehicleOfCatalogue(List<Vehicle> vehicles)
        {
            string vehicleCheck = Console.ReadLine();

            while (vehicleCheck != "Close the Catalogue")
            {

                
                foreach (var vehicle in vehicles)
                {
                   
                    if (vehicle.Model.Contains(vehicleCheck))
                    {
                        Console.WriteLine($"Type: {vehicle.VehicleType}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }

                vehicleCheck = Console.ReadLine();
            }
            
        }
    }
}
