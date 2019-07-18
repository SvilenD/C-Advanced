namespace P02_SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var first = new HashSet<int>();
            var second = new HashSet<int>();

            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums[0];
            int m = nums[1];

            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }

            var result = new HashSet<int>();

            foreach (var num in first)
            {
                if (second.Contains(num))
                {
                    result.Add(num);
                }
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}