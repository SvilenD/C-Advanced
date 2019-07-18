namespace CustomLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private class CustomNode 
        {
            public CustomNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; private set; }

            public CustomNode Next { get; set; }

            public CustomNode Previous { get; set; }
        }

        private CustomNode head;
        private CustomNode tail;

        public T Head
        {
            get
            {
                this.CheckIfIsEmpty();
                return this.head.Value;
            }
        }

        public T Tail
        {
            get
            {
                this.CheckIfIsEmpty();
                return this.tail.Value;
            }
        }

        public int Count { get; private set; }

        public void AddHead(T value)
        {
            var newNode = new CustomNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldHead = this.head;
                oldHead.Previous = newNode;
                newNode.Next = oldHead;
                this.head = newNode;
            }

            this.Count++;
        }

        public void AddTail(T value)
        {
            var newNode = new CustomNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldTail = this.tail;
                oldTail.Next = newNode;
                newNode.Previous = oldTail;
                this.tail = newNode;
            }

            this.Count++;
        }

        public void Clear()
        {

            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        public bool Contains(T value)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }
            return false;
        }

        public void Remove(T value)
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                var nodeValue = currentNode.Value;

                if (nodeValue.Equals(value))
                {
                    var previousNode = currentNode.Previous;
                    var nextNode = currentNode.Next;

                    if (previousNode != null)
                    {
                        previousNode.Next = nextNode;
                    }

                    if (nextNode != null)
                    {
                        nextNode.Previous = previousNode;
                    }

                    if (this.head == currentNode)
                    {
                        this.head = nextNode;
                    }

                    if (this.tail == currentNode)
                    {
                        this.tail = previousNode;
                    }
                    this.Count--;
                }

                currentNode = currentNode.Next;
            }
        }

        public T RemoveHead()
        {
            this.CheckIfIsEmpty();

            var value = this.head.Value;

            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newHead = this.head.Next;
                newHead.Previous = null;
                this.head.Next = null;
                this.head = newHead;
            }

            this.Count--;
            return value;
        }

        public T RemoveTail()
        {
            this.CheckIfIsEmpty();

            var value = this.tail.Value;

            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newTail = this.tail.Previous;
                this.tail.Previous = null;
                newTail.Next = null;
                this.tail = newTail;
            }

            this.Count--;
            return value;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];

            var currentNode = this.head;
            var index = 0;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }

            return array;
        }

        private void CheckIfIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Customs Linked List is empty!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}