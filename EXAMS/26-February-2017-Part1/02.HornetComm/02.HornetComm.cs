using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkForStop = Console.ReadLine();

            var messages = new List<KeyValuePair<string, string>>();
            var broadcasts = new List<KeyValuePair<string, string>>();

            while (checkForStop != "Hornet is Green")
            {
                string[] input =
                    checkForStop
                        .Split(new string[] {" <-> "}, StringSplitOptions.None)
                        .ToArray();

                if (input[0].All(char.IsDigit))
                {
                    //PRIVATE
                    if (isCharOrDigit(input[1]))
                    {
                        string number = new string(input[0].Reverse().ToArray());
                        string message = input[1];
                        
                        messages.Add(new KeyValuePair<string, string>(number, message));
                        
                        
                    }
                }
                
                else if (!input[0].Any(char.IsDigit))
                {
                    if (input[0].All(char.IsWhiteSpace))
                    {
                        continue;
                    }
                     //BROADCAST

                    if (isCharOrDigit(input[1]))
                    {
                        string message = input[0];
                        string frequency = MakingLowerLetterUpperAndTheOtherwayAround(input[1]);
                        broadcasts.Add(new KeyValuePair<string, string>(frequency, message));
                            
                    }
                }
                checkForStop = Console.ReadLine();
               
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Key} -> {message.Value}");
                }
            }
        }

        static string MakingLowerLetterUpperAndTheOtherwayAround(string input)
        {
            string result = string.Empty;
            char[] letter = input.ToCharArray();
            
            for (int i = 0; i < letter.Length; i++)
            {

                if (char.IsLetter(letter[i]))
                {
                    if (char.IsUpper(letter[i]))
                    {
                        result += char.ToLower(letter[i]);
                        
                    }
                    else
                    {
                      result +=  char.ToUpper(letter[i]);
                    }
                }
                else
                {
                    result += letter[i];
                }
            }

            return result;
        }

        static bool isCharOrDigit(string letter)
        {
            if (letter.All(x => Char.IsDigit(x) || Char.IsLetter(x)))
            {
                return true;
            }
            return false;
        }
    }
}
