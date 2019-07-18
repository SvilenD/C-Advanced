namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainPerson
    {
        public Person KeyPerson { get; set; }

        public List<Person> Parents { get; private set; } = new List<Person>();

        public List<Person> Children { get; private set; } = new List<Person>();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.KeyPerson}");
            result.AppendLine($"Parents:");
            if (this.Parents.Any())
            {
                result.AppendLine($"{string.Join(Environment.NewLine, this.Parents)}");
            }
            result.AppendLine($"Children:");
            result.AppendLine($"{string.Join(Environment.NewLine, this.Children)}");

            return result.ToString().TrimEnd();
        }
    }
}