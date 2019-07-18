using System;
using System.Linq;

namespace ArraySum
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            long sum = ArraySum(array, array.Length);

            Console.WriteLine(sum);
        }

        private static long ArraySum(int[] array, int index)
        {
            index--;

            if (index == 0)
            {
                return array[index];
            }

            return array[index] + ArraySum(array, index);
        }
    }
}