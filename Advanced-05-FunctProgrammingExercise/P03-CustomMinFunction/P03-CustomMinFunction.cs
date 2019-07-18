namespace P03_CustomMinFunction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNum = nums =>
            {
                int min = int.MaxValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                }
                return min;
            };

            Action<int> print = p => Console.WriteLine(p);

            print(minNum(numbers));
        }
    }
}