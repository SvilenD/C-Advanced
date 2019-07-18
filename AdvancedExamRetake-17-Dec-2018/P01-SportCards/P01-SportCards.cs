namespace P01_SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var cardsData = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0]?.ToLower() == "end")
                {
                    break;
                }
                else if (input[0]?.ToLower() == "check")
                {
                    if (cardsData.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} is not available!");
                    }
                }
                else
                {
                    string card = input[0];
                    string sport = input[1];
                    double price = double.Parse(input[2]);

                    if (cardsData.ContainsKey(card) == false)
                    {
                        cardsData.Add(card, new Dictionary<string, double>());
                    }
                    if (cardsData[card].ContainsKey(sport) == false)
                    {
                        cardsData[card].Add(sport, 0);
                    }
                    cardsData[card][sport] = price;
                }
            }

            foreach (var card in cardsData.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{card.Key}:");
                foreach (var item in card.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"  -{item.Key} - {item.Value:f2}");
                }
            }
        }
    }
}