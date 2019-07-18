namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;

            private int index;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = new List<Book>(books);
                this.index = -1;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;

                if (this.index < books.Count)
                {
                    return true;
                }

                return false;
            }
            public void Reset()
            {
                this.index = -1;
            }

            public Book Current
            {
                get
                {
                    return this.books[index];
                }
            }

            object IEnumerator.Current => this.Current;
        }    }}