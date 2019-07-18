using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FilterByAge
{
    class Program
    {

        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();
            for (int i = 0; i < peopleCount; i++)
            {
                var info = Console.ReadLine().Split(", ");

                var person = new Person
                {
                    Name = info[0],
                    Age = int.Parse(info[1])
                };
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;
            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            Func<Person, string> selectFunc;
            string printFormat = Console.ReadLine();
            if (printFormat == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            else
            {
                selectFunc = p => p.Name;
            }

            people
                .Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
