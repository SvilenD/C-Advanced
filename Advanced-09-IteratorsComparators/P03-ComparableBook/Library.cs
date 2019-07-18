namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book> 
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.books)
            {
                yield return book;
            }
            //return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //private class LibraryIterator : IEnumerator<Book>
        //{
        //    private SortedSet<Book> books;

        //    private int index;

        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = new SortedSet<Book>(books);
        //        this.Reset();
        //    }

        //    public Book Current
        //    {
        //        get
        //        {
        //            return this.books[index];
        //        }
        //    }

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        index++;
        //        if (index < this.books.Count)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public void Reset()
        //    {
        //        this.index = -1;
        //    }
        //}
    }
}