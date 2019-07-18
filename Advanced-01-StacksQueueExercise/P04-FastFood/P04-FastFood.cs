namespace P04_FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FastFood
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < input.Length; i++)
            {
                var client = orders.Peek();
                if (quantity >= client)
                {
                    orders.Dequeue();
                    quantity -= client;
                }
            }
            if (orders.Count < 1)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
        }
    }
}