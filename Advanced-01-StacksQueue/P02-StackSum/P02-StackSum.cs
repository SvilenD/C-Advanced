using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            foreach (var num in numbers)
            {
                stack.Push(num);
            }
            while (true)
            {
                var input = Console.ReadLine().ToLower().Split();

                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (input[0] == "remove")
                {
                    int numsToRemove = int.Parse(input[1]);
                    if (numsToRemove > stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < numsToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}