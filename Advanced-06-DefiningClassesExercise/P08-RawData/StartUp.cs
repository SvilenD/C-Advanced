namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            var carsList = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double[] tiresPressure = new double[] { double.Parse(input[5]), double.Parse(input[7]), double.Parse(input[9]), double.Parse(input[11]) };
                int[] tiresAge = new int[] { int.Parse(input[6]), int.Parse(input[8]), int.Parse(input[10]), int.Parse(input[12]) };

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tiresPressure, tiresAge);
                carsList.Add(car);
            }

            string filterType = Console.ReadLine();
            if (filterType == "fragile")
            {
                foreach (var car in carsList.Where(c => c.Cargo.Type == filterType && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (filterType == "flamable")
            {
                foreach (var car in carsList.Where(c => c.Cargo.Type == filterType && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
