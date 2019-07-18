namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            HashSet<Person> hashPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);

                Person person = new Person(name, age);

                hashPeople.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}