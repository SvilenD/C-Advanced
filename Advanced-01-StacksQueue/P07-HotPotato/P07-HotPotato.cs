using System;
using System.Collections.Generic;

namespace P07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split();
            var children = new Queue<string>(input);
            int num = int.Parse(Console.ReadLine());

            int count = 1;
            while (children.Count > 1)
            {
                var child = children.Dequeue();

                if (count % num == 0)
                {
                    Console.WriteLine($"Removed {child}");
                }
                else
                {
                    children.Enqueue(child);
                }
                count++;
            }

            Console.WriteLine($"Last is {children.Peek()}");
        }
    }
}