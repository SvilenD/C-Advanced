using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_CupsBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int[] bottlesCapacity = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int wastedWater = 0;

            var cups = new Queue<int>(cupsCapacity);
            var bottles = new Stack<int>(bottlesCapacity);

            while (cups.Any() && bottles.Any())
            {
                var currentBottle = bottles.Pop();
                var currentCup = cups.Peek();
                while (currentCup > 0)
                {
                    if (currentCup <= currentBottle)
                    {
                        wastedWater += currentBottle - currentCup;
                        cups.Dequeue();
                        break;
                    }
                    else
                    {
                        currentCup -= currentBottle;
                        if (bottles.Count < 1)
                        {
                            break;
                        }
                        currentBottle = bottles.Pop();
                    }
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}