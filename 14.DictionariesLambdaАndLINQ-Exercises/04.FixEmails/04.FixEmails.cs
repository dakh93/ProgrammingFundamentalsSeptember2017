using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string mail = Console.ReadLine();

            int counter = 1;
            Dictionary<string, string> listOfPeople = new Dictionary<string, string>();
            while (input != "stop")
            {
                bool check = CheckForBadDomain(mail);
                if (check)
                {
                    input = Console.ReadLine();
                    if (input != "stop")
                    {
                        mail = Console.ReadLine();

                    }
                    continue;
                    
                }
                else
                {
                    
                    listOfPeople[input] = mail;

                    input = Console.ReadLine();
                    if (input != "stop")
                    {
                        mail = Console.ReadLine();
                    
                    }
                }
            }
            foreach (var people in listOfPeople)
            {
                Console.WriteLine($"{people.Key} -> {people.Value}");
            }
        }

        static bool CheckForBadDomain(string mail)
        {
            char[] mailToChar = mail.ToCharArray();
            string result = string.Empty;
            bool isBad = false;
            for (int i = mailToChar.Length -2 ; i < mailToChar.Length; i++)
            {
                result += mailToChar[i];
            }
            if (result == "uk" || result == "us")
            {
                isBad = true;
            }
            return isBad;
        }
    }
}
