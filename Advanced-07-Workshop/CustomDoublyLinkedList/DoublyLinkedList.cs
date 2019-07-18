namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class ListNode 
        {
            public T Value { get; private set; }

            public ListNode NextNode { get; set; }

            public ListNode PreviousNode { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;
        public int Count { get; private set; }

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

        public void AddFirst(T element)
        {
            var newHead = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                var oldHead = this.head;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            var newTail = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public void Clear()
        {

            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T RemoveFirst()
        {
            CheckIfIsEmpty();
            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head = this.head.NextNode;
                this.head.PreviousNode = null;
            }

            Count--;
            return this.head.Value;
        }

        public T RemoveLast()
        {
            CheckIfIsEmpty();

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail = this.tail.PreviousNode;
                this.tail.NextNode = null;
            }

            this.Count--;
            return this.tail.Value;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            var currentNode = this.head;

            int index = 0;
            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                index++;
                currentNode = currentNode.NextNode;
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
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}