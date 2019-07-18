using System;

namespace P02_NestedLoopsToRecursion
{
    class Program
    {
        private static int[] arr;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            arr = new int[n];
            PrintNestedLoops(n, 0);
        }

        private static void PrintNestedLoops(int n, int counter)
        {
            if (counter >= n)
            {
                Console.WriteLine($"{string.Join(" ", arr)}");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                arr[counter] = i;
                PrintNestedLoops(n, counter + 1);
            }
        }
    }
}