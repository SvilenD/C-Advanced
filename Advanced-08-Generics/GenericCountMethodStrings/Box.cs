namespace GenericCountMethodStrings
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box()
        {
            this.values = new List<T>();
        }

        private List<T> values;

        public List<T> Values => this.values;

        public void Add(T item)
        {
            this.values.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstValue = values[firstIndex];
            var secondValue = values[secondIndex];
            values[firstIndex] = secondValue;
            values[secondIndex] = firstValue;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Count; i++)
            {
                var item = values[i];
                result.AppendLine($"{typeof(T)}: {item}");
            }

            return result.ToString();
        }
    }
}
