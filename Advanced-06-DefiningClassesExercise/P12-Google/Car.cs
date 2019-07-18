namespace DefiningClasses
{
    using System;

    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public Car()
            : this(string.Empty, 0)
        {
        }

        public string Model { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            if (this.Model != string.Empty)
            {
                return $"Car: {Environment.NewLine}" +
                    $"{this.Model} {this.Speed}";
            }
            else
            {
                return "Car:";
            }
        }
    }
}