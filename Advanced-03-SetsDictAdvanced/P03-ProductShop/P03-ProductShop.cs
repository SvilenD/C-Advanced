namespace P03_ProductShop
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>(); // с decimal гърми щото са олигофрени

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Revision")
                {
                    break;
                }
                var shop = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);

                if (shops.ContainsKey(shop) == false)
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop][product] = price;
            }

            foreach (var kvp in shops)
            {
                var shop = kvp.Key;
                var products = kvp.Value;

                Console.WriteLine($"{shop}->");
                foreach (var productKvp in products)
                {
                    Console.WriteLine($"Product: {productKvp.Key}, Price: {productKvp.Value}");
                }
            }
        }
    }
}