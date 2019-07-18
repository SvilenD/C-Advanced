using System;
using System.Linq;

namespace QuickSort
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input == String.Empty)
            {
                return;
            }

            int[] array = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            QuickSort<int>.Sort(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }

    internal class QuickSort<T> where T : IComparable
    {
        public static void Sort(T[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(T[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int pivot = Partition(array, low, high);

            Sort(array, low, pivot - 1);
            Sort(array, pivot + 1, high);
        }

        private static int Partition(T[] array, int low, int high)
        {
            if (low >= high)
            {
                return low;
            }

            int i = low;
            int j = high + 1;

            while (true)
            {
                while (IsLess(array[++i], array[low]))
                {
                    if (i == high)
                    {
                        break;
                    }
                }

                while (IsLess(array[low], array[--j]))
                {
                    if (j == low)
                    {
                        break;
                    }
                }

                if (i >= j)
                {
                    break;
                }

                Swap(array, i, j);
            }

            Swap(array, low, j);

            return j;
        }

        private static void Swap(T[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        private static bool IsLess(T first, T second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}