using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class StartUp
    {

        static void Main(string[] args)
        {
            char[] delimiters = {' ', ',', '!', '?', '.'};
            string[] text =
                Console.ReadLine()
                    .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToArray();
            List<string> foundPalindromes = new List<string>();
            foreach (var word in text)
            {
                bool isPalindrome = CheckForPalindrome(word);

                if (isPalindrome)
                {
                    foundPalindromes.Add(word);
                }
            }
            foundPalindromes.Sort();
            Console.WriteLine(String.Join(", ",foundPalindromes));
        }

        static bool CheckForPalindrome(string word)
        {
            char[] reversedWord = word.ToCharArray();
            Array.Reverse(reversedWord);

            string reversed = new string(reversedWord);

            if (word.Equals(reversed))
            {
                return true;
            }
            return false;
        }
    }
}
