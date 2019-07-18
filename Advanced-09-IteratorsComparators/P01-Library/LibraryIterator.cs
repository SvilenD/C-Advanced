namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    public class LibraryIterator : IEnumerator<Book>
    {
        private  List<Book> books;

        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex < this.books.Count)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public Book Current
        {
            get
            {
                return this.books[currentIndex];
            }
        }

        object IEnumerator.Current => this.Current;
    }}