namespace P11_PartyReservationFilterModule
{
using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
            var guests = Console.ReadLine().Split().ToList();

            var commands = new List<Func<string, string, bool>>();
            var parameters = new List<string>();

            while (true)
            {
                var input = Console.ReadLine().Split(';');
                if (input[0] == "Print")
                {
                    break;
                }
                else if (input[0] == "Add filter")
                {
                    commands.Add(GetFunc(input[1]));
                    parameters.Add(input[2]);
                }
                else if (input[0] == "Remove filter")
                {
                    commands.Remove(GetFunc(input[1]));
                    parameters.Remove(input[2]);
                }
            }

            for (int i = 0; i < commands.Count; i++)
            {
                guests = guests.Where(x => commands[i](x, parameters[i]) == false).ToList();
            }

            Console.WriteLine(string.Join(' ', guests));
        }

        private static Func<string, string, bool> GetFunc(string command)
        {
            if (command == "Starts with")
            {
                return (c, p) => c.StartsWith(p);
            }
            else if (command == "Ends with")
            {
                return (c, p) => c.EndsWith(p);
            }
            else if (command == "Length")
            {
                return (c, p) => c.Length == int.Parse(p);
            }
            else if (command== "Contains")
            {
                return (c, p) => c.Contains(p);
            }
            return null;
        }
    }
}