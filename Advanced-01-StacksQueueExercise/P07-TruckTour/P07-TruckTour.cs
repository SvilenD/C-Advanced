namespace P07_TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            var defaultQueue = new Queue<int>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                int difference = input[0] - input[1];
                defaultQueue.Enqueue(difference);
            }

            var orderedQueue = new Queue<int>(defaultQueue);
            int fuel = 0;
            int count = 0;

            while (count < orderedQueue.Count)
            {
                var current = orderedQueue.Dequeue();
                orderedQueue.Enqueue(current);

                if (fuel + current >= 0)
                {
                    fuel += current;
                    count++;
                }
                else
                {
                    fuel = 0;
                    count = 0;
                }
            }

            int index = 0;
            count = 0;
            while (count < orderedQueue.Count)
            {
                if (orderedQueue.Peek() == defaultQueue.Peek())
                {
                    orderedQueue.Enqueue(orderedQueue.Dequeue());
                    count++;
                }
                else
                {
                    count = 0;
                    index++;
                }
                defaultQueue.Enqueue(defaultQueue.Dequeue());
            }
            Console.WriteLine(index);
        }
    }
}