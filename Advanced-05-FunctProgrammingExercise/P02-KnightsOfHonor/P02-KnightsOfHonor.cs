namespace P02_KnightsOfHonor
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string> InsertSirAndPrint = x => Console.WriteLine($"Sir {x}");

            foreach (var name in names)
            {
                InsertSirAndPrint(name);
            }
        }
    }
}