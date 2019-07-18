namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => this.name;

            set
            {
                if (value.Length > 0)
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get => this.age;

            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}