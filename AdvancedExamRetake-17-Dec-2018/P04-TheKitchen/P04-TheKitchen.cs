namespace P04_TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var knives = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            var forks = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            var sets = new Queue<int>();

            while (knives.Count > 0 && forks.Count > 0)
            {
                if (knives.Peek() > forks.Peek())
                {
                    sets.Enqueue(knives.Pop() + forks.Dequeue());
                }
                else if (knives.Peek() == forks.Peek())
                {
                    forks.Dequeue();
                    knives.Push(knives.Pop() + 1);
                }
                else
                {
                    knives.Pop();
                }
            }

            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine($"{string.Join(' ', sets)}");
        }
    }
}