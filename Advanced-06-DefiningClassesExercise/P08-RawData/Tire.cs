namespace DefiningClasses
{
    using System;

    public class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get { return this.pressure; }

            set
            {
                if (value >= 0)
                {
                    this.pressure = value;
                }
                else
                {
                    throw new ArgumentException("Tyre pressure must be positive.");
                }
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Tyre age must be positive.");
                }
            }
        }
    }
}