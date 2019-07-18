namespace DefiningClasses
{
    public class Employee
    {
        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }
        public Employee(string name, decimal salary, string position, string department)
            : this(name, salary, position, department, "n/a", -1)
        {
        }
        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department, email, -1)
        {
        }

        public Employee(string name, decimal salary, string position, string department, int age)
            : this(name, salary, position, department, "n/a", age)
        {
        }

        public string Name { get; private set; }

        public decimal Salary { get; private set; }

        public string Position { get; private set; }

        public string Department { get; private set; }

        public string Email { get; private set; } = "n/a";

        public int Age { get; set; } = -1;
    }
}