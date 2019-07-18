namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var enginesList = new List<Engine>();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                var engineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine engine = null;
                if (engineData.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineData.Length == 3)
                {
                    int displacement = 0;
                    bool isInteger = int.TryParse(engineData[2], out displacement);
                    if (isInteger)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineData[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }

                enginesList.Add(engine);
            }

            var carsList = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                var carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                string engineModel = carArgs[1];

                Engine engine = enginesList.Find(e => e.Model == engineModel);

                Car car = null;

                if (carArgs.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carArgs.Length == 3)
                {
                    int weight = 0;
                    bool IsWeight = int.TryParse(carArgs[2], out weight);
                    if (IsWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = carArgs[2];
                        car = new Car(model, engine, color);
                    }
                }
                else if (carArgs.Length == 4 )
                {
                    int weight = int.Parse(carArgs[2]);
                    string color = carArgs[3];
                    car = new Car(model, engine, weight, color);
                }

                carsList.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, carsList));
        }
    }
}