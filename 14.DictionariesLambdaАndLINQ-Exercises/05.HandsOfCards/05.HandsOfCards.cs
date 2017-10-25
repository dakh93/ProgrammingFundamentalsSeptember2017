using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var input =
                Console.ReadLine();
                    
           
            

            Dictionary<char, int> cardPower = new Dictionary<char, int>()
                {
                    {'J', 11},
                    {'Q', 12},
                    {'K', 13},
                    {'A', 14},
                    {'S', 4},
                    {'H', 3},
                    {'D', 2},
                    {'C', 1}

                };
            Dictionary<string,string[]> oldAdded = new Dictionary<string, string[]>();
            Dictionary<string, int> finalPersonValue = new Dictionary<string, int>();
            while (input != "JOKER")
            {
                var arr = input.Split(':');
                var player = arr[0].Trim();
                string[] personCards =
                    arr[1]
                        .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                        .Distinct()
                        .ToArray();

                
                int sum = 0;

                for (int i = 0; i < personCards.Length; i++)
                {
                    if (oldAdded.ContainsKey(player))
                    {

                        for (int j = 0; j < oldAdded.Count; j++)
                        {
                            
                            for (int k = 0; k < personCards.Length; k++)
                            {
                                    
                                if (oldAdded[player].Contains(personCards[k]))
                                {
                                    personCards[k] = "0";
                                }
                            }

                        }
                        break;
                    }
                    oldAdded.Add(player, personCards);
                    break;

                }

                sum = GetPersonSumOfCards(personCards, cardPower, sum);
                //NEW PERSON OR ADD TO EXISTING ONE
                if (finalPersonValue.ContainsKey(player))
                {
                    finalPersonValue[player] += sum;
                }
                else
                {
                    
                    finalPersonValue.Add(player,sum);
                }

                input = Console.ReadLine();
            }

            foreach (var per in finalPersonValue)
            {
                Console.WriteLine($"{per.Key}: {per.Value}");
            }
        }

        static int GetPersonSumOfCards(string[] personCards,
                                        Dictionary<char, int> cardPower,
                                        int sum)
        {
                for (int i = 0; i < personCards.Length; i++)
                {
                    int multiply = 1;
                    

                    char[] card = personCards[i].ToCharArray();
                    for (int j = 0; j < card.Length; j++)
                    {
                        if (cardPower.ContainsKey(card[j]))
                        {
                            multiply *= cardPower[card[j]];
                        }
                        else
                        {
                            string number = string.Empty;
                            if (card.Length == 1)
                            {
                                number = card[0].ToString();
                            }
                            for (int k = 0; k < card.Length - 1; k++)
                            {
                               
                                number += card[k].ToString();
                            }
                            if (card.Length > 2)
                            {
                                j = card.Length - 2;
                            }
                            multiply *= int.Parse(number);
                        }
                        
                    }
                    sum += multiply;

                }
            return sum;

        }
    }
}
