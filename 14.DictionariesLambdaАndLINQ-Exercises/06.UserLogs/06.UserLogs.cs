using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<int>> kur = new List<List<int>>();

            //kur.Add(new List<int> {1 , 2 , 3});
            //kur.Add(new List<int> {6 , 6 ,6});
            //kur.Add(new List<int> {7 , 7 , 7});
            //kur.Add(new List<int> {8 , 8 , 8});

            //foreach (List<int> sublist in kur)
            //{
            //    foreach (var item in sublist)
            //    {
            //        Console.Write(item);
            //    }
            //    Console.WriteLine();
            //}

            //Dictionary<string, List<string>> patka = new Dictionary<string, List<string>>();

            //patka.Add("Pesho", new List<string>() { "a", "b" });
            //patka.Add("Mara", new List<string>() { "q", "s" });
            //patka.Add("KOKO", new List<string>() { "y", "y" });


            //foreach (var person in patka)
            //{
            //    foreach (var item in person.Value)
            //    {
                   
            //        Console.Write(item);
            //    }
            //    Console.WriteLine();
            //}



            List<string> personCards =
                Console.ReadLine()
                    .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

            Dictionary<string, List<string>> oldAdded = new Dictionary<string, List<string>>();
            for (int i = 0; i < personCards.Count; i++)
            {
              
                    oldAdded.Add(personCards[i], new List<string>(personCards));

                
            }
        }
    }
}
