namespace P09_ListOfPredicates2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program // 75/100  memory limit, iska for + foreach za da mine
    {
        public static void Main()
        {
            var endNum = int.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(1, endNum).ToList(); // създавам поредиза от, до

            HashSet<int> dividers = Console.ReadLine().Split() // пазя уникални числа
                    .Select(int.Parse).ToHashSet();

            List<Predicate<int>> predicates = new List<Predicate<int>>(); 

            foreach (var divider in dividers)
            {
                predicates.Add(x => x % divider == 0);  
            }

            Func<int, List<Predicate<int>>, bool> isDivisible = (n, p) => p.All(x => x(n));

            numbers = numbers.Where(x=> isDivisible(x, predicates)).ToList();

            Action<List<int>> printResult = r => Console.WriteLine(string.Join(' ', r));

            printResult(numbers);
        }
    }
}