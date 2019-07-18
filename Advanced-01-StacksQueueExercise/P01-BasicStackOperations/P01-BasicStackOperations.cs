using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var pushCount = input[0];
            var popCount = input[1];
            var numToFind = input[2];
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(nums[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }
            
            if (stack.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
