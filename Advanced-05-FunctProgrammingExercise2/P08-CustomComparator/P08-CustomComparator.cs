namespace P08_CustomComparator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);

            int[] even = nums.Where(x => x % 2 == 0).ToArray();
            int[] odd = nums.Where(x => x % 2 != 0).ToArray();

            Array.Sort(even, new Comparison<int>(sortFunc));
            Array.Sort(odd, new Comparison<int>(sortFunc));

            Action<int[], int[]> print = (x, y) => Console.WriteLine($"{string.Join(" ", x)} {string.Join(" ", y)}");

            print(even, odd);
        }
    }
}
