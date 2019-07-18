namespace P06_ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divisor = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> removeReverse = x => x.Where(a => a % divisor != 0).Reverse().ToList();

            Console.WriteLine(string.Join(" ", removeReverse(nums)));
        }
    }
}