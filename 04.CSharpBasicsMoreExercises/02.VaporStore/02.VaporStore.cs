using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double gamerBalance = double.Parse(Console.ReadLine());
            double startMoney = gamerBalance;

            double outFall4 = 39.99;
            double CSOG = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOrigins = 39.99;

            bool lamp = true;
            string gameName = string.Empty; ;
            while (lamp)
            {
                if (gamerBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                else
                {
                    double tempBalance = gamerBalance;
                    gameName = Console.ReadLine();
                    if (gameName == "Game Time")
                    {
                        lamp = false;
                        continue;
                    }

                    if (gameName == "OutFall 4")
                    {
                        if (gamerBalance >= outFall4)
                        {
                            gamerBalance -= outFall4;
                            Console.WriteLine($"Bought {gameName}");

                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }

                    }
                    else if (gameName == "CS: OG")
                    {
                        if (gamerBalance >= CSOG)
                        {

                            gamerBalance -= CSOG;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }

                    }
                    else if (gameName == "Zplinter Zell")
                    {
                        if (gamerBalance >= zplinterZell)
                        {
                            gamerBalance -= zplinterZell;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }

                    }
                    else if (gameName == "Honored 2")
                    {
                        if (gamerBalance >= honored2)
                        {
                            gamerBalance -= honored2;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }

                    }
                    else if (gameName == "RoverWatch")
                    {
                        if (gamerBalance >= roverWatch)
                        {
                            gamerBalance -= roverWatch;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }

                    }
                    else if (gameName == "RoverWatch Origins Edition")
                    {
                        if (gamerBalance>= roverWatchOrigins)
                        {
                            gamerBalance -= roverWatchOrigins;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }
                    
                }
            }
            double moneyLeft = startMoney - gamerBalance;
            Console.WriteLine($"Total spent: ${moneyLeft:F2}. Remaining: ${gamerBalance:F2}");
        }
    }
}
