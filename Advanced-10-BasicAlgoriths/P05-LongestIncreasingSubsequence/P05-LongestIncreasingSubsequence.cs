using System;
using System.Linq;

namespace P05_LongestIncreasingSubsequence // si ebalo maikata
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] length = new int[numbers.Length];
            int[] previous = new int[numbers.Length];

            int maxIndex = 0;
            int maxLength = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                int bestLength = 1;
                int prevIndex = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] > numbers[j] && length[j] + 1 >= bestLength)
                    {
                        bestLength = length[j] + 1;
                        prevIndex = j;
                    }
                }
                length[i] = bestLength;
                previous[i] = prevIndex;

                if (bestLength > maxLength)
                {
                    maxLength = bestLength;
                    maxIndex = i;
                }
            }

            int[] result = new int[maxLength];

            int index = 0;
            while (maxIndex != -1)
            {
                result[index++] = numbers[maxIndex];
                maxIndex = previous[maxIndex];
            }

            Array.Reverse(result);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}