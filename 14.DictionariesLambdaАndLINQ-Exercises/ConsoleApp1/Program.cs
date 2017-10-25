using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> kur = new Dictionary<string, List<int>>();
            List<int> pedro =new List<int>() {1, 2, 3};

            kur.Add("Pesho",pedro);
            foreach (var kurec in kur)
            {
                Console.WriteLine($"{kurec} -> {kurec.Value.ToList()} ");
                
            }
        }
    }
}
