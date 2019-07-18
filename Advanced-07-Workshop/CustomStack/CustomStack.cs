namespace Workshop
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStack<Т> : IEnumerable<Т>
    {
        private Т[] values;
        private int count;

        public CustomStack(int initialCapacity)
        {
            this.values = new Т[initialCapacity];
        }

        public CustomStack()
            : this(16)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(Т value)
        {
            if (this.count == this.values.Length)
            {
                var nextValues = new Т[this.values.Length * 2];
                for (int i = 0; i < this.values.Length; i++)
                {
                    nextValues[i] = this.values[i];
                }

                this.values = nextValues;
            }
            this.values[this.count] = value;
            this.count++;
        }

        public Т Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Custom Stack is empty!");
            }
            int lastIndex = this.count - 1;
            var last = this.values[lastIndex];
            this.count--;
            this.values[lastIndex] = default;
            return last;
        }

        public void ForEach(Action<Т> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.values[i]);
            }
        }

        public IEnumerator<Т> GetEnumerator()
        {
            for (int i = this.count - 1; i >= 0; i--)
            {
                yield return this.values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}