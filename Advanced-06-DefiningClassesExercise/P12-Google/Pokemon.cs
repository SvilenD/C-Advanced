namespace DefiningClasses
{
    using System;

    public class Pokemon
    {
        public Pokemon(string name, string element)
        {
            this.Name = name;
            this.Element = element;
        }

        public string Name { get; set; }

        public string Element { get; set; }

        public override string ToString()
        {
            return $"{Environment.NewLine}{this.Name} {this.Element}";
        }
    }
}