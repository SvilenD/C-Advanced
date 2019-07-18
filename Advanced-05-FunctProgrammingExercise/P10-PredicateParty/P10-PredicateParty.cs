using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Party!")
                {
                    break;
                }

                string command = input[0];
                string filter = input[1];
                string criteria = input[2];
                if (command == "Double")
                {
                    var guestsToAdd = new List<string>();

                    if (filter == "StartsWith")
                    {
                        guestsToAdd = guests.Where(x => x.StartsWith(criteria)).ToList();
                    }
                    else if (filter == "EndsWith")
                    {
                        guestsToAdd = guests.Where(x => x.EndsWith(criteria)).ToList();
                    }
                    else if (filter == "Length")
                    {
                        guestsToAdd = guests.Where(x => x.Length == int.Parse(criteria)).ToList();
                    }

                    foreach (var name in guestsToAdd)
                    {
                        int index = guests.IndexOf(name);
                        guests.Insert(index, name);
                    }
                }
                else if (command == "Remove")
                {
                    if (filter == "StartsWith")
                    {
                        guests.RemoveAll(x => x.StartsWith(criteria));
                    }
                    else if (filter == "EndsWith")
                    {
                        guests.RemoveAll(x => x.EndsWith(criteria));
                    }
                    else if (filter == "Length")
                    {
                        guests.RemoveAll(x => x.Length == int.Parse(criteria));
                    }
                }
            }

            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party"
                : "Nobody is going to the party");
        }
    }
}