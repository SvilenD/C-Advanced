namespace DefiningClasses
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distance = 0;
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

        public double FuelAmount
        {
            get { return this.fuelAmount; }

            set
            {
                if (value >= 0)
                {
                    this.fuelAmount = value;
                }
            }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }

            set
            {
                if (value >= 0)
                {
                    this.fuelConsumption = value;
                }
            }
        }

        public double Distance
        {
            get => this.distance;

            set
            {
                if (value >= 0)
                {
                    this.distance = value;
                }
            }
        }

        public void Drive(double distance)
        {
            if (this.fuelAmount >= this.fuelConsumption * distance)
            {
                this.distance += distance;
                this.fuelAmount -= this.fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}