namespace MergeSort
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == String.Empty)
            {
                return;
            }

            int[] arr = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            MergeSort<int>.Sort(arr);

            Console.WriteLine(String.Join(" ", arr));
        }
    }

    internal class MergeSort<T> where T : IComparable
    {
        private static T[] aux;

        public static void Sort(T[] array)
        {
            aux = new T[array.Length];
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(T[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int mid = low + (high - low) / 2;

            Sort(array, low, mid);
            Sort(array, mid + 1, high);

            Merge(array, low, mid, high);
        }

        private static void Merge(T[] array, int low, int mid, int high)
        {
            if (IsLess(array[mid], array[mid + 1]))
            {
                return;
            }

            for (int index = low; index < high + 1; index++)
            {
                aux[index] = array[index];
            }

            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    array[k] = aux[j++];
                }
                else if (j > high)
                {
                    array[k] = aux[i++];
                }
                else if (IsLess(aux[i], aux[j]))
                {
                    array[k] = aux[i++];
                }
                else
                {
                    array[k] = aux[j++];
                }
            }
        }

        private static bool IsLess(T first, T second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}