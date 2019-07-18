namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 16;
        private T[] data;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public CustomStack(params T[] items)
        {
            this.capacity = Math.Max(initialCapacity, items.Length);
            this.count = items.Length;
            this.data = new T[capacity];

            Array.Copy(items, 0, data, 0, items.Length);
        }

        public T Pop()
        {
            if (this.count > 0)
            {
                var last = data[count];
                data[count] = default;
                this.count--;
                return last;
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
        }

        public void Push(params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (this.count > this.capacity - 1)
                {
                    data[count] = items[i];
                }
                else
                {
                    ResizeArray();
                    data[count] = items[i];
                }
                this.count++;
            }
        }

        private void ResizeArray()
        {
            var newData = new T[this.capacity * 2];
            Array.Copy(this.data, 0, newData, 0, data.Length);
            data = newData;
            this.capacity = data.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
