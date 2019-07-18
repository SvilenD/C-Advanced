namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new AnimalsCollection
            {
                new Cat("Gosho", 50),
                new Dog("Pesho", 100), 
                new Cat("Ivan", 100)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.SayHello());
            }
            Console.WriteLine(animals.Count());
            Console.WriteLine(animals.FirstOrDefault(a=>a.Name.StartsWith('P')).Name); //след имплементация на IEnumerable имам и LINQ методи 

            var sortedSet = new SortedSet<IAnimal>(animals);

            foreach (var item in sortedSet)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Weight);
            }


            var sortedAnimals = new SortedSet<IAnimal>(new IAnimalWeightComparer());
            sortedAnimals.Add(new Cat("gesho", 1000));
            sortedAnimals.Add(new Cat("pesho", 100));
            sortedAnimals.Add(new Cat("mesho", 200));



            foreach (var item in sortedAnimals)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Weight);
            }
        }
    }
}