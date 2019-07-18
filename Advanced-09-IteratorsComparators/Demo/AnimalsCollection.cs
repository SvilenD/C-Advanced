using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    public class AnimalsCollection : IAnimal, IEnumerable<IAnimal> // добавям IEnumerable<T> за да имам foreach и т.н.
    {
        private List<IAnimal> animals;

        public int Count { get; private set; }

        public AnimalsCollection()
        {
            this.animals = new List<IAnimal>();
        }

        public void Add(IAnimal animal)
        {
            this.animals.Add(animal);
            this.Count++;
        }

        public string Name { get; set; }

        public string SayHello()
        {
            return "Hello";
        }

        public IEnumerator<IAnimal> GetEnumerator()
        {
            return new IAnimalEnumerator(animals);
        }

        IEnumerator IEnumerable.GetEnumerator() // OLDschool версията на GetEnumerator, казваме и вземай от новата
        {
            return this.GetEnumerator();
        }
    }
}
