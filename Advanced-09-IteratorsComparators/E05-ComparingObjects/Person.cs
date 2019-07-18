namespace ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            int retultName = this.Name.CompareTo(other.Name);
            if (retultName == 0)
            {
                int resultAge = this.Age.CompareTo(other.Age);
                if (resultAge == 0)
                {
                    return this.Town.CompareTo(other.Town);
                }

                return resultAge;
            }
            return retultName;
        }
    }
}