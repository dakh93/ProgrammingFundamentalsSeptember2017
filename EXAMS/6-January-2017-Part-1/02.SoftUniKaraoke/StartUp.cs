using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
   
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] separator = {' ', ','};
            string[] participants =
                Console.ReadLine()
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] songs =
                Console.ReadLine()
                    .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, HashSet<string>> currSinger =
                new Dictionary<string, HashSet<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }

                CheckIfSingerAndSongExists(input,separator, participants, songs,currSinger);

            }

            if (currSinger.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                
                foreach (var singer in currSinger.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    
                    
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var awards in singer.Value.OrderBy(x => x))
                    {
                        
                        Console.WriteLine($"--{awards}");
                    }
                    
                     
                }
            }




        }

        private static void CheckIfSingerAndSongExists(
            string input, char[] separator,
            string[] participants, string[] songs,
        Dictionary<string, HashSet<string>> currSinger)
        {
           
            string[] performance =
                input.Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string singer = performance[0];
            string song = performance[1];
            string award = performance[2];

            
            if (participants.Contains(singer) && songs.Contains(song))
            {
                
                if (!currSinger.ContainsKey(singer))
                {
                    currSinger.Add(singer, new HashSet<string>());
                    currSinger[singer].Add(award);
                }
                else
                {
                    if (!currSinger[singer].Contains(song) || !currSinger[singer].Contains(award))
                    {
                        currSinger[singer].Add(award);
                    }
                }
            }

            
        }
    }
}
