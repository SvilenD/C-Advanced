namespace Repository
{
    using System.Collections.Generic;

    public class Repository
    {
        private Dictionary<int, Person> data;
        private int id;

        public int Count => this.data.Count;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
            this.id = 0;
        }

        public void Add(Person person)
        {
            this.data.Add(this.id, person);
            this.id++;
        }

        public Person Get(int id)
        {
            return this.data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (data.ContainsKey(id))
            {
                this.data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }

            return false;
        }
    }
}