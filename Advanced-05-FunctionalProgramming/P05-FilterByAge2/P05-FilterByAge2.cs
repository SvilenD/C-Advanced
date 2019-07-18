using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FilterByAge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();
            for (int i = 0; i < peopleCount; i++)
            {
                var input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());

            Func<int, bool> tester = CheckConditions(condition, ageFilter);
            string printFormat = Console.ReadLine();

            Action<KeyValuePair<string, int>> printer = GenerateOutput(printFormat);

            foreach (var person in people.Where(p => tester(p.Value)))
            {
                printer(person);
            }
        }

        private static Action<KeyValuePair<string, int>> GenerateOutput(string format)
        {
            switch (format)
            {
                case "name age": return person => Console.WriteLine($"{person.Key} - {person.Value}");
                case "name": return person => Console.WriteLine($"{person.Key}");
                default:
                    return null;
            }
        }

        private static Func<int, bool> CheckConditions(string condition, int age)
        {
            switch (condition)
            {
                case "older": return x => x >= age;
                case "younger": return x => x < age;
                default: return null;
            }
        }
    }
}
