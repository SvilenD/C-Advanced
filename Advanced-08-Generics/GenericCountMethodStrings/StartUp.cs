namespace GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var box = new Box<string>();

            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                box.Add(Console.ReadLine());
            }

            string comparisonItem = Console.ReadLine();
            int count = CountGreaterValues(box.Values, comparisonItem);

            Console.WriteLine(count);
        }

        public static int CountGreaterValues<T>(List<T> values, T element) 
            where T : IComparable
        {
            int count = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}