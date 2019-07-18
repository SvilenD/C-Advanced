using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(nums);
            var evenNums = new Queue<int>();
            while (queue.Count > 0)
            {
                var num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    evenNums.Enqueue(num);
                }
            }
            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}