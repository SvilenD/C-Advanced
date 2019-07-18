namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption; 

        public string Make
        {
            get
            {
                return this.make;
            }

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
            get
            {
                return this.model;
            }

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
            get
            {
                return this.year;
            }

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
            get
            {
                return this.fuelQuantity;
            }

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
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                if (value > 0)
                {
                    this.fuelConsumption = value;
                }
            }
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption / 100) >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel: {this.FuelQuantity:F2}L");
            return result.ToString();
        }
    }
}