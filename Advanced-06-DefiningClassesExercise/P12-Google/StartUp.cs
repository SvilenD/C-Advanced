namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToLower() == "end")
                {
                    break;
                }

                string name = input[0];

                Person person = GetPerson(name, people);

                switch (input[1].ToLower())
                {
                    case "car": AddCarInfo(input, person);
                        break;
                    case "company": AddCompanyInfo(input, person);
                        break;
                    case "children": AddChild(input, person);
                        break;
                    case "parents": AddParent(input, person);
                        break;
                    case "pokemon": AddPokemon(input, person);
                        break;
                    default:
                        break;
                }
            }

            var filter = Console.ReadLine();
            Console.WriteLine(people.FirstOrDefault(p => p.Name == filter));
        }

        private static Person GetPerson(string name, List<Person> people)
        {
            if (people.Any(p => p.Name == name))
            {
                return people.FirstOrDefault(p => p.Name == name);
            }
            else
            {
                Person person = new Person(name);
                people.Add(person);
                return person;
            }
        }

        private static void AddChild(string[] input, Person person)
        {
            string name = input[2];
            string birthday = input[3];
            person.Children.Add(new Child(name, birthday));
        }

        private static void AddCompanyInfo(string[] input, Person person)
        {
            string companyName = input[2];
            string department = input[3];
            decimal salary = decimal.Parse(input[4]);
            person.Company.Name = companyName;
            person.Company.Department = department;
            person.Company.Salary = salary;
        }

        private static void AddCarInfo(string[] input, Person person)
        {
            string model = input[2];
            int speed = int.Parse(input[3]);
            person.Car.Model = model;
            person.Car.Speed = speed;
        }

        private static void AddParent(string[] input, Person person)
        {
            string name = input[2];
            string birthday = input[3];
            person.Parents.Add(new Parent(name, birthday));
        }

        private static void AddPokemon(string[] input, Person person)
        {
            string name = input[2];
            string element = input[3];
            person.Pokemons.Add(new Pokemon(name, element));
        }
    }
}