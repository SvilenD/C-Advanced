namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Salad
    {
        private List<Vegetable> vegetables;

        public string Name { get; private set; }

        public Salad(string name)
        {
            this.Name = name;
            this.vegetables = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            return this.vegetables.Sum(c => c.Calories);
        }

        public int GetProductCount()
        {
            return this.vegetables.Count();
        }

        public void Add(Vegetable product)
        {
            this.vegetables.Add(product);
        }

        public override string ToString()
        {
            return $"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:" + Environment.NewLine +
                   $"{string.Join(Environment.NewLine, this.vegetables)}";
        }
    }
}