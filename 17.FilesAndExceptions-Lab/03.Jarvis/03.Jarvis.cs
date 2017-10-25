using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Robot
    {
        public List<Head> Heads { get; set; }
        public List<Arms> Arms { get; set; }
        public List<Legs> Legs { get; set; }
        public List<Torso> Torsos { get; set; }
    }
    class Arms
    {
        public int EnergyConsmp { get; set; }
        public int ReachDistance { get; set; }
        public int CountOfFingers { get; set; }
    }

    class Legs
    {
        public int EnergyConsmp { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
    }

    class Torso
    {
        public int EnergyConsmp { get; set; }
        public double ProcessorSize { get; set; }
        public string HousingMaterial { get; set; }
    }

    class Head
    {
        public int EnergyConsmp { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            long maximumEnergyCapacity = long.Parse(Console.ReadLine());

            string[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            Robot robot = new Robot();
            
            while (input[0] != "Assemble!")
            {
                AddingBodyParts(input, robot);



                input =
                    Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
            }

            if (robot.Arms == null)
                robot.Arms = new List<Arms>();
            if (robot.Legs == null)
                robot.Legs = new List<Legs>();
            if (robot.Heads == null)
                robot.Heads = new List<Head>();
            if (robot.Torsos == null)
                robot.Torsos = new List<Torso>();

            if (robot.Arms.Count > 1 && robot.Legs.Count > 1 &&
                robot.Heads.Count > 0 && robot.Torsos.Count > 0)
            {
                CheckEnergyConsume(robot, maximumEnergyCapacity);
            }
            else
            {
                Console.WriteLine($"We need more parts!");
            }

        }

        private static void CheckEnergyConsume(Robot robot, long maxCap)
        {
            long consumeEnergy =
                robot.Arms.OrderBy(x => x.EnergyConsmp).First().EnergyConsmp +
                robot.Arms.OrderBy(x => x.EnergyConsmp).Skip(1).Take(1).First().EnergyConsmp +
                robot.Legs.OrderBy(x => x.EnergyConsmp).First().EnergyConsmp +
                robot.Legs.OrderBy(x => x.EnergyConsmp).Skip(1).Take(1).First().EnergyConsmp +
                robot.Heads.OrderBy(x => x.EnergyConsmp).First().EnergyConsmp +
                robot.Torsos.OrderBy(x => x.EnergyConsmp).First().EnergyConsmp;

            if (consumeEnergy > maxCap)
            {
                Console.WriteLine("We need more power!");
            }
            else
            {
                Console.WriteLine("Jarvis:");
                foreach (var head in robot.Heads.OrderBy(x => x.EnergyConsmp).Take(1))
                {
                    Console.WriteLine($"#Head:");
                    Console.WriteLine($"###Energy consumption: {head.EnergyConsmp}");
                    Console.WriteLine($"###IQ: {head.IQ}");
                    Console.WriteLine($"###Skin material: {head.SkinMaterial}");
                }
                foreach (var torso in robot.Torsos.OrderBy(x => x.EnergyConsmp).Take(1))
                {
                    Console.WriteLine($"#Torso:");
                    Console.WriteLine($"###Energy consumption: {torso.EnergyConsmp}");
                    Console.WriteLine($"###Processor size: {torso.ProcessorSize:f1}");
                    Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
                }
                foreach (var arm in robot.Arms.OrderBy(x => x.EnergyConsmp).Take(2))
                {
                    Console.WriteLine($"#Arm:");
                    Console.WriteLine($"###Energy consumption: {arm.EnergyConsmp}");
                    Console.WriteLine($"###Reach: {arm.ReachDistance}");
                    Console.WriteLine($"###Fingers: {arm.CountOfFingers}");
                }
                foreach (var leg in robot.Legs.OrderBy(x => x.EnergyConsmp).Take(2))
                {
                    Console.WriteLine($"#Leg:");
                    Console.WriteLine($"###Energy consumption: {leg.EnergyConsmp}");
                    Console.WriteLine($"###Strength: {leg.Strenght}");
                    Console.WriteLine($"###Speed: {leg.Speed}");
                }
            }

        }

        static void AddingBodyParts (string[] input, Robot robot)
        {
            //HEAD
            if (input[0] == "Head")
            {
               Head currHead = new Head();
                
                currHead.EnergyConsmp =int.Parse(input[1]);
                currHead.IQ =int.Parse(input[2]);
                currHead.SkinMaterial = input[3];
                if (robot.Heads == null)
                {
                    robot.Heads = new List<Head>();
                    
                }
                robot.Heads.Add(currHead);
                // probvai ako e = dali trqbva da se smenq
                if (robot.Heads.Any(x => x.EnergyConsmp > currHead.EnergyConsmp))
                {
                    robot.Heads.Clear();
                    robot.Heads.Add(currHead);
                   
                }
            }
            else if (input[0] == "Leg")
            {
                Legs currLeg = new Legs();

                currLeg.EnergyConsmp = int.Parse(input[1]);
                currLeg.Strenght = int.Parse(input[2]);
                currLeg.Speed = int.Parse(input[3]);
                if (robot.Legs == null)
                {
                    robot.Legs = new List<Legs>();
                }
                robot.Legs.Add(currLeg);
            }
            else if (input[0] == "Torso")
            {
                Torso currTorso = new Torso();
                
                currTorso.EnergyConsmp = int.Parse(input[1]);
                currTorso.ProcessorSize = double.Parse(input[2]);
                currTorso.HousingMaterial = input[3];
                if (robot.Torsos == null)
                {
                    robot.Torsos = new List<Torso>();
                }
                robot.Torsos.Add(currTorso);
                if (robot.Torsos.Any(x => x.EnergyConsmp > currTorso.EnergyConsmp))
                {
                    robot.Torsos.Clear();
                    robot.Torsos.Add(currTorso);
                }
            }
            else if (input[0] == "Arm")
            {
                Arms currArm = new Arms();
                currArm.EnergyConsmp = int.Parse(input[1]);
                currArm.ReachDistance = int.Parse(input[2]);
                currArm.CountOfFingers = int.Parse(input[3]);
                if (robot.Arms == null)
                {
                    robot.Arms = new List<Arms>();
                }
                robot.Arms.Add(currArm);
            }
        }
    }
}
