namespace P04_TravelMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" > ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToUpper() == "END")
                {
                    break;
                }

                string country = input[0];
                string town = input[1];
                double price = double.Parse(input[2]);
                if (dict.ContainsKey(country) == false)
                {
                    dict.Add(country, new Dictionary<string, double>());
                }
                if (dict[country].ContainsKey(town) == false)
                {
                    dict[country].Add(town, price);
                }
                if (dict[country][town] > price)
                {
                    dict[country][town] = price;
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (var kvp in dict.OrderBy(c => c.Key))
            {
                result.Append($"{kvp.Key} ->");
                foreach (var item in kvp.Value.OrderBy(p => p.Value))
                {
                    result.Append($" {item.Key} -> {item.Value}");
                }
                result.AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}