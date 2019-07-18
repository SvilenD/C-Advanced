namespace Demo
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var animals = new AnimalsCollection();
            animals.Add(new Cat("Gosho"));
            animals.Add(new Dog("Pesho"));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.SayHello());
            }
            Console.WriteLine(animals.Count);
            Console.WriteLine(animals.FirstOrDefault(a=>a.Name.StartsWith('P')).Name); //след имплементация на IEnumerable имам и LINQ методи 
        }
    }
}