namespace P01_ReverseArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            PrintInReverseOrder(array, array.Length - 1);
        }

        private static void PrintInReverseOrder(int[] array, int index)
        {
            if (index < 0)
            {
                return;
            }
            Console.Write(array[index] + " ");
            PrintInReverseOrder(array, index - 1);
        }
    }
}
