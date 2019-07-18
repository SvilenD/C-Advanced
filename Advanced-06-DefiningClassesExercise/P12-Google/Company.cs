namespace DefiningClasses
{
    using System;

    public class Company
    {
        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public Company()
            : this(string.Empty, string.Empty, 0)
        {
        }

        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            if (this.Name != string.Empty)
            {
                return $"Company: {Environment.NewLine}" +
                    $"{this.Name} {this.Department} {this.Salary:f2}";
            }
            else
            {
                return "Company:";
            }
        }
    }
}