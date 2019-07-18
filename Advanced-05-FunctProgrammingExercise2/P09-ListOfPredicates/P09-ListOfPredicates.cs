namespace P09_ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program //75/100 memory limit, iska foreach za da mine
    {
        public static void Main()
        {
            var endNum = int.Parse(Console.ReadLine());

            HashSet<int> dividers = Console.ReadLine().Split()
                    .Select(int.Parse).ToHashSet();

            Func<int, HashSet<int>, bool> isDivisibleByAll = (n, nums) => nums.All(x => n % x == 0);

            var numbers = new List<int>();
            for (int i = 1; i <= endNum; i++)
            {
                if (isDivisibleByAll(i, dividers))
                {
                    numbers.Add(i);
                }
            }

            Action<List<int>> printResult = r => Console.WriteLine(string.Join(' ', r));

            printResult(numbers);
        }
    }
}

   //public static bool IsValid(int num)
   // {
   //     Func<int, int, bool> notDivisible = (number, div) => number % div != 0;

   //     foreach (var divisor in dividers)
   //     {
   //         if (notDivisible(num, divisor))
   //         {
   //             return false;
   //         }
   //     }
   //     return true;
   // }