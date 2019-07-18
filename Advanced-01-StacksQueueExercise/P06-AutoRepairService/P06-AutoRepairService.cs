namespace P06_AutoRepairService
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        public static void Main(string[] args)
        {
            var cars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var waiting = new Queue<string>(cars);
            var served = new Stack<string>();

            while (true)
            {
                var input = Console.ReadLine().Split('-');
                if (input[0] == "Service" && waiting.Count > 0)
                {
                    var currentCar = waiting.Dequeue();
                    served.Push(currentCar);
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                }
                else if (input[0] == "CarInfo")
                {
                    var carToFind = input[1];
                    if (waiting.Contains(carToFind))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else if (served.Contains(carToFind))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (input[0] == "History")
                {
                    Console.WriteLine($"{string.Join(", ", served)}");
                }
                else if (input[0] == "End")
                {
                    if (waiting.Count > 0)
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", waiting)}");
                    }
                    Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");
                    break;
                }
            }
        }
    }
}