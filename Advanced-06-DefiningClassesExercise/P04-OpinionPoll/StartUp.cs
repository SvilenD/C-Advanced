namespace DefiningClasses
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            foreach (var person in family.AgeFilter(30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
