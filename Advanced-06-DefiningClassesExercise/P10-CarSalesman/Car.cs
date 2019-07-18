using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine, weight, DefaultValueString)
        {
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine, DefaultValueInt, color)
        {
        }

        public Car(string model, Engine engine)
            : this(model, engine, DefaultValueInt, DefaultValueString)
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Model}:");
            result.AppendLine($"{Engine.ToString()}");
            if (this.Weight == -1)
            {
                result.AppendLine("  Weight: n/a");
            }
            else
            {
            result.AppendLine($"  Weight: {this.Weight}");
            }
                result.Append($"  Color: {this.Color}");
            return result.ToString();
        }
    }
}