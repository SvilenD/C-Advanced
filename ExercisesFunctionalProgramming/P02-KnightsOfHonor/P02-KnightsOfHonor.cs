namespace P02_KnightsOfHonor
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Action<string[]> insertSirAndPrint = x => Console.WriteLine($"Sir {string.Join(Environment.NewLine + "Sir ", x)}");

            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            insertSirAndPrint(names);
        }
    }
}
