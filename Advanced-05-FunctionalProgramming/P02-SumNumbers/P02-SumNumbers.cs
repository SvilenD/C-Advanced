namespace P02_SumNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string[], int[]> Parse = nums => nums.Select(int.Parse).ToArray();

            var numbers = Parse(Console.ReadLine()
               .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));

            Func<int[], int> countFunc = n => n.Count();
            Func<int[], int> sumFunc = n => n.Sum();
            Console.WriteLine(countFunc(numbers));
            Console.WriteLine(sumFunc(numbers));
            //Console.WriteLine(numbers.Count());
            //Console.WriteLine(numbers.Sum());
        }
    }
}