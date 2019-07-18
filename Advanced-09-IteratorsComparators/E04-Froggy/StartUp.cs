namespace E04_Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var lake = new Lake(Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Console.WriteLine($"{string.Join(", ", lake)}");
        }
    }
}