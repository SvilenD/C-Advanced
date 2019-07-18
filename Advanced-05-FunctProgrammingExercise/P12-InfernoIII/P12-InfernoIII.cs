namespace P12_InfernoIII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var gems = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            var exclusionFilters = new Stack<KeyValuePair<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(';');
                if (input[0] == "Forge")
                {
                    break;
                }
                var command = input[0]; // Commands can be: "Exclude", "Reverse" or "Forge".
                var filter = input[1]; // Filter types are: "Sum Left", "Sum Right" and "Sum Left Right". 
                var parameter = int.Parse(input[2]); // All filter parameters will be an integer. 

                if (command == "Exclude")
                {
                    exclusionFilters.Push(new KeyValuePair<string, int>(filter, parameter));
                }
                else if (command == "Reverse" && exclusionFilters.Count > 0)
                {
                    exclusionFilters.Pop();
                }
            }

            ExecuteExclusions(gems, exclusionFilters);

            Console.WriteLine(string.Join(" ", gems));
        }

        private static void ExecuteExclusions(List<int> gems, Stack<KeyValuePair<string, int>> exclusionFilters)
        {
            foreach (var filter in exclusionFilters)
            {
                switch (filter.Key)
                {
                    case "Sum Left":
                        FilterLeft(filter.Value, gems);
                        break;
                    case "Sum Right":
                        FilterRight(filter.Value, gems);
                        break;
                    case "Sum Left Right":
                        FilterLeftRight(filter.Value, gems);
                        break;
                }
            }
        }

        private static void FilterLeftRight(int value, List<int> gems)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                var leftGemPower = (i == 0) ? 0 : gems[i - 1];
                var rightGemPower = (i == gems.Count - 1) ? 0 : gems[i + 1];

                if (leftGemPower + gems[i] + rightGemPower == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterRight(int value, List<int> gems)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                var rightNum = (i == gems.Count - 1) ? 0 : gems[i + 1];

                if (gems[i] + rightNum == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterLeft(int value, List<int> gems)
        {
            for (int i = gems.Count - 1; i >= 0; i--)
            {
                int leftNum = (i > 0) ? gems[i - 1] : 0;

                if (gems[i] + leftNum == value)
                {
                    gems.RemoveAt(i);
                }
            }
        }
    }
}