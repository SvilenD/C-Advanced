namespace Demo
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// добавям IEnumerable<T> за да имам foreach и т.н.
    /// </summary>
    public class AnimalsCollection : IAnimal, IEnumerable<IAnimal>, IComparable<IAnimal>
    {
        private List<IAnimal> animals;

        public AnimalsCollection()
        {
            this.animals = new List<IAnimal>();
        }

        public void Add(IAnimal animal)
        {
            this.animals.Add(animal);
        }

        public string Name { get; set; }

        public int Weight { get; set; }

        public string SayHello()
        {
            return "Hello";
        }

        /// <summary>
        /// yield return замества всичките глупости със създаването на клас 
        /// GetEnumerator за логиката какъв елемент ще връща колекцията при обхождане
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IAnimal> GetEnumerator()
        {
            for (int i = 0; i < this.animals.Count; i++)
            {
                yield return this.animals[i]; 
            }
        }

        /// <summary>
        ///  OLDschool версията на GetEnumerator, казваме и вземай от новата
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() 
        {
            return this.GetEnumerator();
        }

        public int CompareTo(IAnimal other)
        {
            var weightDiff = other.Weight - this.Weight; //низходящ ред
            if (weightDiff == 0)
            {
                return this.Name.CompareTo(other.Name); //сравнявам по имена
            }
            return weightDiff;
        }
    }
}