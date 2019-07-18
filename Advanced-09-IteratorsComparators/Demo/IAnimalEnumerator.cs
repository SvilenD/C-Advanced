namespace Demo
{
    using System.Collections;
    using System.Collections.Generic;

    public class IAnimalEnumerator : IEnumerator<IAnimal>
    {
        private List<IAnimal> animals;
        private int index = -1;

        public IAnimalEnumerator(List<IAnimal> animals)
        {
            this.animals = animals;
        }

        public IAnimal Current
        {
            get
            {
                return this.animals[index];
            }
        }

        object IEnumerator.Current => this.Current; // OLDschool версията взема стойност от новото

        public void Dispose() //za sega prazen
        {
        }

        public bool MoveNext()
        {
            this.index++;

            if (this.index < this.animals.Count)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}