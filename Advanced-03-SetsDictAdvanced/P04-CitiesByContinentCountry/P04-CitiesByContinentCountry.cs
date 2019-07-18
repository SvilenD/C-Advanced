namespace P04_CitiesByContinentCountry
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (dict.ContainsKey(input[0]) == false)
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                if (dict[continent].ContainsKey(country) == false)
                {
                    dict[continent].Add(country, new List<string>());
                }
                dict[continent][country].Add(city);
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine(kvp.Key + ":");
                foreach (var nKvp in kvp.Value)
                {
                    Console.WriteLine($"{nKvp.Key} -> {string.Join(", ", nKvp.Value)}");
                }
            }
        }
    }
}