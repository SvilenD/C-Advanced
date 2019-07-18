namespace P10_PredicateParty
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
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

                Func<string, string, bool> predicate = GetFunc(filter);
                if (command == "Double")
                {
                    var guestsToAdd = guests.Where(x => predicate(x, criteria)).ToList();

                    foreach (var name in guestsToAdd)
                    {
                        int index = guests.IndexOf(name);
                        guests.Insert(index, name);
                    }
                }
                else if (command == "Remove")
                {
                    guests = guests.Where(x => predicate(x, criteria) == false).ToList();
                }
            }

            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party!"
                : "Nobody is going to the party!");
        }

        static Func<string, string, bool> GetFunc(string filter)
        {
            if (filter == "StartsWith")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filter == "EndsWith")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filter == "Length")
            {
                return (x, c) => x.Length == int.Parse(c);
            }
            return null;
        }
    }
}