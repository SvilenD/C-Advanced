namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());            
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}