namespace P04_CupsBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var cupsCapacity = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var bottles = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int wastedLittersOfWater = 0;

            while (cupsCapacity.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cupsCapacity.Peek();

                while (currentCup > 0)
                {
                    int currentBottle = bottles.Pop();
                    if (currentCup < currentBottle)
                    {
                        wastedLittersOfWater += currentBottle - currentCup;
                    }
                    currentCup -= currentBottle;
                }
                cupsCapacity.Dequeue();
            }

            if (cupsCapacity.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cupsCapacity)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}