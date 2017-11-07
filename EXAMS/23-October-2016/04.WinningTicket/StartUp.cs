using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = {'@', '#', '$', '^'};
            string[] tickets =
                Console.ReadLine()
                    .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                char[] kur = ticket.Distinct().ToArray();
                bool isJackpot = kur.Length == 1 && symbols.Any(x => x.Equals(kur[0]));
                if (isJackpot)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{kur[0]} Jackpot!");
                    continue;
                }
                {
                    char[] firstHalf = ticket.ToCharArray().Take(10).ToArray();
                    char[] secondHalf = ticket.ToCharArray().Skip(10).Take(10).ToArray();

                    int currCount = 1;
                    int oldCount = 0;
                    char firstSymbol = ' ';
                    for (int i = 1; i < firstHalf.Length; i++)
                    {
                        if (firstHalf[i] == firstHalf[i -1])
                        {
                            currCount++;
                            if (oldCount < currCount)
                            {
                                oldCount = currCount;
                                firstSymbol = firstHalf[i];
                            }
                        }
                        else
                        {
                            currCount = 1;
                        }
                    }
                    

                    int currCountTwo = 1;
                    int oldCountTwo = 0;
                    char secondSymbol = ' ';
                    for (int i = 1; i < secondHalf.Length; i++)
                    {
                        if (secondHalf[i] == secondHalf[i - 1])
                        {
                            currCountTwo++;
                            if (oldCountTwo < currCountTwo)
                            {
                                 oldCountTwo = currCountTwo;
                                 secondSymbol = secondHalf[i];
                            }
                        }
                        else
                        {
                            currCountTwo = 1;
                        }
                    }

                    int maxSeq = Math.Min(oldCount, oldCountTwo);

                    if (maxSeq >= 6 && 
                        maxSeq < 10 && 
                        firstSymbol == secondSymbol && 
                        symbols.Any(x => x.Equals(firstSymbol)))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {maxSeq}{secondSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
