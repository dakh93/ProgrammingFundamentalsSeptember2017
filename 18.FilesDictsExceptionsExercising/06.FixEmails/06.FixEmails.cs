using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = 
                File.ReadAllText(@"..\..\input.txt")
                .Split(new []{Environment.NewLine}, StringSplitOptions.None)
                .ToArray();
            int nameCnt = 0;
            int emailCnt = 1;
            string name = fileContent[nameCnt];
            string mail = fileContent[emailCnt];

            
            Dictionary<string, string> listOfPeople = new Dictionary<string, string>();
            while (name != "stop")
            {
                bool check = CheckForBadDomain(mail);
                if (check)
                {
                    emailCnt += 2;
                    nameCnt += 2;

                    name = fileContent[nameCnt];
                    if (name != "stop")
                    {
                        mail = fileContent[emailCnt];

                    }
                    continue;

                }
                else
                {
                    listOfPeople[name] = mail;

                    emailCnt += 2;
                    nameCnt += 2;
                    name = fileContent[nameCnt];
                    if (name != "stop")
                    {
                        mail = fileContent[emailCnt];

                    }
                }
            }
            foreach (var people in listOfPeople)
            {
                File.AppendAllText(@"..\..\output.txt",
                    people.Key + " -> " + people.Value + Environment.NewLine);
            }
            string separatorOfDiffInputs = "-------------------";
            File.AppendAllText(@"..\..\output.txt",
                separatorOfDiffInputs + Environment.NewLine);
        }

        static bool CheckForBadDomain(string mail)
        {
            char[] mailToChar = mail.ToCharArray();
            string result = string.Empty;
            bool isBad = false;
            for (int i = mailToChar.Length - 2; i < mailToChar.Length; i++)
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
