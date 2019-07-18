namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<Tire[]> tiresList = new List<Tire[]>();
        static List<Engine> enginesList = new List<Engine>();
        static List<Car> carsList = new List<Car>();
        public static void Main()
        {
            GetTiresData();
            GetEnginesData();
            GetCars();

            foreach (var car in carsList.Where(x => x.Year >= 2017)
                .Where(x => x.Tires.Sum(t => t.Pressure) >= 9 && x.Tires.Sum(t => t.Pressure) <= 10))
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }

        private static void GetTiresData()
        {
            while (true)
            {
                var tyresInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tyresInfo[0] == "No")
                {
                    break;
                }

                var firstTire = new Tire(int.Parse(tyresInfo[0]), double.Parse(tyresInfo[1]));
                var secondTire = new Tire(int.Parse(tyresInfo[2]), double.Parse(tyresInfo[3]));
                var thirdTire = new Tire(int.Parse(tyresInfo[4]), double.Parse(tyresInfo[5]));
                var forthTire = new Tire(int.Parse(tyresInfo[6]), double.Parse(tyresInfo[7]));

                var tyreSet = new Tire[4] { firstTire, secondTire, thirdTire, forthTire };

                tiresList.Add(tyreSet);
            }
        }

        private static void GetEnginesData()
        {
            while (true)
            {
                var engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (engineInfo[0] == "Engines")
                {
                    break;
                }

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                enginesList.Add(engine);
            }
        }

        private static void GetCars()
        {
            while (true)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (carInfo[0] == "Show" && carInfo[1] == "special")
                {
                    break;
                }

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine engine = enginesList[int.Parse(carInfo[5])];
                Tire[] tires = tiresList[int.Parse(carInfo[6])];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                carsList.Add(car);
            }
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make
        {
            get => this.make;

            set
            {
                if (value.Length > 0)
                {
                    this.make = value;
                }
            }
        }

        public string Model
        {
            get => this.model;

            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
            }
        }

        public int Year
        {
            get => this.year;

            set
            {
                if (value > 1900 && value < 2030)
                {
                    this.year = value;
                }
            }
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            set
            {
                if (value >= 0)
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;

            set
            {
                if (value >= 0)
                {
                    this.fuelConsumption = value;
                }
            }
        }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; } = new Tire[4];

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            bool enoughFuel = this.fuelQuantity >= this.fuelConsumption * distance / 100;
            if (enoughFuel)
            {
                this.fuelQuantity -= this.fuelConsumption * distance / 100;
            }
            else
            {
                throw new Exception("Not Enough Fuel.");
            }
        }

    }

    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get => this.horsePower;

            set
            {
                if (value >= 0)
                {
                    this.horsePower = value;
                }
            }
        }

        public double CubicCapacity
        {
            get => this.cubicCapacity;

            set
            {
                if (value >= 0)
                {
                    this.cubicCapacity = value;
                }
            }
        }
    }

    public class Tire
    {
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        private int year;
        private double pressure;

        public int Year { get; set; }

        public double Pressure { get; set; }
    }
}