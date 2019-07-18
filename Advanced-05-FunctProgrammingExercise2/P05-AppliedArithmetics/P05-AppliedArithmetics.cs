namespace P05_AppliedArithmetics
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> addFunc = x => x.Select(a => a + 1).ToArray();
            Func<int[], int[]> subtractFunc = x => x.Select(a => a - 1).ToArray();
            Func<int[], int[]> multiplyFunc = x => x.Select(a => a * 2).ToArray();
            Action<int[]> printAction = x => Console.WriteLine(string.Join(" ", x));

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    nums = addFunc(nums);
                }
                else if (command == "subtract")
                {
                    nums = subtractFunc(nums);
                }
                else if (command == "multiply")
                {
                    nums = multiplyFunc(nums);
                }
                else if (command == "print")
                {
                    printAction(nums);
                }
            }
        }
    }
}