using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var enqueueCount = input[0];
            var dequeueCount = input[1];
            var numToFind = input[2];
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < enqueueCount; i++)
            {
                queue.Enqueue(nums[i]);
            }
            for (int i = 0; i < dequeueCount; i++)
            {
                queue.Dequeue();
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }
            if (queue.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
