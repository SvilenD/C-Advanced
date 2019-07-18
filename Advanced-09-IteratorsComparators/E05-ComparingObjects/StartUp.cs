namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0].ToUpper() == "END")
                {
                    break;
                }

                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];
                var person = new Person(name, age, town);
                people.Add(person);
            }

            int personNumber = int.Parse(Console.ReadLine());

            Person currentPerson = people[personNumber - 1];

            int equalPeople = 0;
            int differentPeople = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (currentPerson.CompareTo(people[i]) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    differentPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {differentPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
