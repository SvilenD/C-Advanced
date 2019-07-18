namespace P01_CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            Dictionary<double, int> numsCount = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (numsCount.ContainsKey(input[i]) == false)
                {
                    numsCount[input[i]] = 1;
                }
                else
                {
                    numsCount[input[i]]++;
                }
            }

            foreach (var num in numsCount)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}