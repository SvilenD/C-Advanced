using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var locksInput = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int value = int.Parse(Console.ReadLine());

            var barrel = new Stack<int>(bulletsInput);
            var locks = new Queue<int>(locksInput);
            int count = 0;

            while (barrel.Count > 0 && locks.Count > 0)
            {
                var bullet = barrel.Pop();
                if (bullet <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                count++;
                if (count == gunBarrelSize && barrel.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int bulletsUsed = bulletsInput.Count() - barrel.Count();
                int moneyEarned = value - bulletsUsed * bulletPrice;
                Console.WriteLine($"{barrel.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}