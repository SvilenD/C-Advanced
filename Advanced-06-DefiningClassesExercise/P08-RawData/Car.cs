namespace DefiningClasses
{
    using System;
    public class Car
    {
        public String Model { get; private set; }

        public Engine Engine { get; private set; }

        public Cargo Cargo { get; private set; }

        public Tire[] Tires { get; private set; }

        public Car(string model, int speed, int power, int weight, string type, 
            double[] pressures, int[] ages)
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.Tires = GetTires(pressures, ages);
        }

        public Tire[] GetTires(double[] pressures, int[] ages)
        {
            Tire[] tires = new Tire[4];
            for (int i = 0; i < 4; i++)
            {
                tires[i] = new Tire(pressures[i], ages[i]);
            }

            return tires;
        }
    }
}