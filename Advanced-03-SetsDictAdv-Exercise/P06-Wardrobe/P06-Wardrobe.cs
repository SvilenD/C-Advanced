namespace P06_Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split(" -> ");
                var color = input[0];
                var clothes = input[1].Split(',');

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int index = 0; index < clothes.Length; index++)
                {
                    if (wardrobe[color].ContainsKey(clothes[index]) == false)
                    {
                        wardrobe[color].Add(clothes[index], 0);
                    }
                    wardrobe[color][clothes[index]]++;
                }
            }

            var itemToFind = Console.ReadLine().Split();
            foreach (var kvp in wardrobe)
            {
                string color = kvp.Key;
                Console.WriteLine($"{color} clothes:");
                foreach (var cloth in kvp.Value)
                {
                    if (color == itemToFind[0] && cloth.Key == itemToFind[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}