namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Car = new Car();
            this.Parents = new List<Parent>();
            this.Pokemons = new List<Pokemon>();
            this.Children = new List<Child>();
        }

        public string Name { get; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Parent> Parents { get; private set; }

        public List<Pokemon> Pokemons { get; set; }

        public List<Child> Children { get; private set; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(this.Name);
            info.AppendLine($"{this.Company}");
            info.AppendLine($"{this.Car}");
            info.AppendLine($"Pokemon:{string.Join("", this.Pokemons)}");
            info.AppendLine($"Parents:{string.Join("", this.Parents)}");
            info.Append($"Children: {string.Join("", this.Children)}");

            return info.ToString();
        }
    }
}