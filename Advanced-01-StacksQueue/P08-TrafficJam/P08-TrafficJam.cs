using System;
using System.Collections.Generic;

namespace P08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassingCount = int.Parse(Console.ReadLine());

            var carsQueue = new Queue<string>();
            int count = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (input == "green")
                {
                    int length = Math.Min(carsPassingCount, carsQueue.Count);
                    for (int i = 0; i < length; i++)
                    {
                        var passingCar = carsQueue.Dequeue();
                        Console.WriteLine($"{passingCar} passed!");
                        count++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }    
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}