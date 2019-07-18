namespace CustomList
{
    using System;
    using System.Collections.Generic;


    public class CustomList<T>
    {
        private const int defaultSize = 4; // по условие е 2
        private T[] items;

        public int Count { get; private set; }

        public CustomList(int capacity)
        {
            this.items = new T[capacity];
        }
        public CustomList()
            : this(defaultSize)
        {
        }

        public T this[int index]
        {
            get
            {
                if (IsInRange(index))
                {
                    return this.items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                if (IsInRange(index))
                {
                    this.items[index] = value;
                }
            }
        }

        public void Add(T value)
        {
            if (this.items.Length == this.Count)
            {
                Resise();
            }
            this.items[this.Count] = value;
            this.Count++;
        }

        public bool Contains(T value)
        {
            foreach (var item in items)
            {
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (IsInRange(index))
            {
                items[index] = default;
                ShiftElementsLeft(index);
                this.Count--;
            }
        }

        private void ShiftElementsLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = items[i + 1];
            }

            this.items[Count - 1] = default;
        }

        public void Shrink()
        {
            if (this.Count * 2 < this.items.Length)
            {
                var smallerArray = new T[items.Length / 2];
                for (int i = 0; i < this.Count; i++)
                {
                    smallerArray[i] = this.items[i];
                }
                this.items = smallerArray;
            }
        }

        private bool IsInRange(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return true;
            }

            return false;
        }
        private void Resise()
        {
            var newArray = new T[this.Count * 2];
            this.items.CopyTo(newArray, 0);
            this.items = newArray;
        }
    }
}