namespace P06_ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divisor = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> removeReverse = (nums, div) => nums.Where(a => a % div != 0).Reverse().ToList();

            numbers = removeReverse(numbers, divisor);

            Action<List<int>> printNums = n => Console.WriteLine(string.Join(' ', n));

            printNums(numbers);
        }
    }
}