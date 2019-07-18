namespace P03_PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            SortedSet<string> periodicTable = new SortedSet<string>();

            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var elements = Console.ReadLine().Split();
                for (int index = 0; index < elements.Length; index++)
                {
                    periodicTable.Add(elements[index]);

                }
            }
            Console.WriteLine($"{string.Join(" ", periodicTable)}");
        }
    }
}