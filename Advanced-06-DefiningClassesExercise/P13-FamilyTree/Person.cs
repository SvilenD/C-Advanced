namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person()
        {
            this.Name = string.Empty;
            this.Birthday = string.Empty;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<Person> Parents { get; private set; }

        public List<Person> Children { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"{this.Name} {this.Birthday}");
            result.AppendLine("Parents:");
            foreach (var parent in this.Parents)
            {
                result.AppendLine($"{parent.Name} {parent.Birthday}"); 
            }
            result.AppendLine("Children:");
            foreach (var child in this.Children)
            {
                result.AppendLine($"{child.Name} {child.Birthday}");
            }
            return result.ToString();
        }
    }
}