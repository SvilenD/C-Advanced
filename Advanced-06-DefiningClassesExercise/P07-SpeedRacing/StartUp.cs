namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            while (true)
            {
                var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                var model = command[1];
                var car = cars.Find(c => c.Model == model);
                double distance = double.Parse(command[2]);

                car.Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}