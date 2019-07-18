namespace P07_Truck_Tour2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp

    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Queue<int[]> petrolPumps = new Queue<int[]>();

            for (int i = 0; i < count; i++)
            {
                var pump = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(pump);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var pump in petrolPumps)
                {
                    int fuel = pump[0];
                    int distance = pump[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}