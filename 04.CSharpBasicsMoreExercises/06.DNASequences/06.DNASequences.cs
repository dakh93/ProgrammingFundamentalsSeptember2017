using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());

            char[] letter = { 'A', 'C', 'G', 'T' };
            int[] letterValue = { 1, 2, 3, 4 };

            string result = string.Empty;
            int sequence = 0;

            

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        int currentSum = letterValue[i] + letterValue[j] + letterValue[k];
                        if (currentSum >= matchSum)
                        {
                            result = "O" + letter[i] + letter[j] + letter[k] + "O ";
                        }
                        else
                        {
                            result = "X" + letter[i] + letter[j] + letter[k] + "X ";
                        }
                        sequence++;
                        Console.Write(result);
                        currentSum = 0;
                        if (sequence == 4)
                        {
                            sequence = 0;
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
