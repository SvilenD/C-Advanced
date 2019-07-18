namespace P11_PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static List<string[]> commands = new List<string[]>();
        static Func<List<string>, string, List<string>> filterStartsWith = (g, c) => g.Where(x => !x.StartsWith(c)).ToList();
        static Func<List<string>, string, List<string>> filterEndsWith = (g, c) => g.Where(x => !x.EndsWith(c)).ToList();
        static Func<List<string>, string, List<string>> filterContains = (g, c) => g.Where(x => !x.Contains(c)).ToList();
        static Func<List<string>, string, List<string>> filterLength = (g, len) => g.Where(x => x.Length != int.Parse(len)).ToList();

        public static void Main()
        {
            var guests = Console.ReadLine().Split().ToList();

            var input = Console.ReadLine().Split(';');
            while (input[0] != "Print")
            {
                string command = input[1];
                string parameter = input[2];

                if (input[0] == "Add filter")
                {
                    commands.Add(new[] { command, parameter });
                }
                else if (input[0] == "Remove filter")
                {
                    commands.RemoveAll(c => c[0] == command && c[1] == parameter);
                }

                input = Console.ReadLine().Split(';');
            }

            guests = ExecuteCommands(guests);

            Console.WriteLine(string.Join(' ', guests));
        }

        private static List<string> ExecuteCommands(List<string> guests)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                var command = commands[i][0];
                var param = commands[i][1];

                if (command == "Starts with")
                {
                    guests = filterStartsWith(guests, param);
                }
                else if (command == "Ends with")
                {
                    guests = filterEndsWith(guests, param);
                }
                else if (command == "Contains")
                {
                    guests = filterContains(guests, param);
                }
                else if (command == "Length")
                {
                    guests = filterLength(guests, param);
                }
            }

            return guests;
        }
    }
}