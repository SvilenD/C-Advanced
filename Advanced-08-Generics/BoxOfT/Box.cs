namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T> where T : struct //ограничавам класа да работи само с примитивни типове данни - структури
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public T Remove()
        {
            var last = this.values.Last();
            this.values.RemoveAt(this.values.Count - 1);
            return last;
        }

        public int Count
        {
            get
            {
                return this.values.Count;
            }
        }
    }
}