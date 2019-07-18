namespace P04_FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] boundaries = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int start = boundaries[0];
            int end = boundaries[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = num => num % 2 == 0;
            Predicate<int> isOdd = num => num % 2 != 0;
            //Predicate<int> filter = x => oddOrEven == "odd" ? x % 2 != 0 : x % 2 == 0;

            string numType = Console.ReadLine();

            if (numType == "odd")
            {
                numbers = numbers.Where(n => isOdd(n)).ToList();
            }
            else if (numType == "even")
            {
                numbers = numbers.Where(n => isEven(n)).ToList();
            }
            //Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
            Action<List<int>> printResult = nums => Console.WriteLine(string.Join(' ', nums));
            printResult(numbers);
        }
    }
}