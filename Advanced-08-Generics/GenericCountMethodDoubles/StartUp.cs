namespace GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var box = new Box<double>();

            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            var comparisonItem = double.Parse(Console.ReadLine());
            int count = CountGreaterValues(box.Values, comparisonItem);

            Console.WriteLine(count);
        }

        public static int CountGreaterValues<T>(List<T> values, double comparisonItem)
            where T : IComparable
        {
            int count = 0;
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(comparisonItem) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}