using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            string language = string.Empty;
            if (country == "USA" || country == "England")
            {
                language = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                language = "Spanish";
            }
            else
            {
                language = "unknown";
            }

            Console.WriteLine(language);
        }
    }
}
