namespace ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T>
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

        public void Print()
        {
            try
            {
                Console.WriteLine(data[index]);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}