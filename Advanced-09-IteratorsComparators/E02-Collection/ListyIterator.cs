namespace Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index;

        public List<T> Collection { get; }

        public ListyIterator()
        {
            this.data = new List<T>();
            this.index = 0;
        }
        public void Create(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                data.Add(elements[i]);
            }
        }

        public bool HasNext()
        {
            if (data.Count - 1 > index)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public string Print()
        {
            try
            {
                return data[index].ToString();
            }
            catch (Exception)
            {
                return "Invalid Operation!";
            }
        }

        public string PrintAll()
        {
            try
            {
                StringBuilder result = new StringBuilder();
                foreach (var item in data)
                {
                    result.Append($"{item} ");
                }
                return result.ToString().Trim();
            }
            catch (Exception)
            {
                return "Invalid Operation!";
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}